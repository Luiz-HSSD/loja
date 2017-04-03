using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;

namespace DAL
{
    public abstract class AbstractDAL : IDAL
    {
        public AbstractDAL(string nometabela)
        {
            this.nometabela = nometabela;
        }
        private string nometabela;
        public abstract void Alterar(EntidadePersistente entidade);
        public virtual void Excluir(int codigo)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from Clientes where codigo = " + codigo;
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o cliente " + codigo);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public abstract void Incluir(EntidadePersistente entidade);

        public virtual DataTable Listagem()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from "+nometabela, Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
