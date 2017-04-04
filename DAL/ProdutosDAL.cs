using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ProdutosDAL : AbstractDAL
    {
        public ProdutosDAL() : base("PRODUTOS")
        {
        }

        public DataTable ProdutosEmFalta()
        {
            DataTable tabela=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select codigo, nome from produtos where estoque=0",Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }
        public override void Incluir(EntidadePersistente entidade)
        {
            ProdutoInformation produto = (ProdutoInformation)entidade;
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Produtos(nome,preco,estoque) values (@nome,@preco,@estoque); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@preco", produto.Preco);
                cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
                cn.Open();
                produto.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Number);
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
        public override void Alterar(EntidadePersistente entidade)
        {
            ProdutoInformation produto = (ProdutoInformation)entidade;
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "AlterarProduto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", produto.Codigo);
                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@preco", produto.Preco);
                cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
                cmd.Parameters.Add("@valorEstoque", SqlDbType.Int);
                cmd.Parameters["@valorEstoque"].Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();
                decimal valorEstoque = Convert.ToDecimal(cmd.Parameters["@valorEstoque"]);
                if (valorEstoque < 500)
                {
                    throw new Exception("Atenção! Valor baixo no estoque");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Number);
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

    }
}
