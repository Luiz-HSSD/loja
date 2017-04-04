using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelos;
using System.Collections;
using System.Data;

namespace BLL
{
    public class ProdutosBLL : AbstractBLL
    {
        public ProdutosBLL() : base(new ProdutosDAL())
        {
        }
        public DataTable ProdutosEmFalta()
        {
            ProdutosDAL produtos = (ProdutosDAL)idal;
            return produtos.ProdutosEmFalta();
        }


        public override void Incluir(EntidadePersistente entidade)
        {
           
            ProdutoInformation produto = (ProdutoInformation)entidade;
            // Nome do produto é obrigatório
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }
            // O preço do produto não pode ser negativo
            if (produto.Preco < 0)
            {
                throw new Exception("Preço do produto não pode ser negativo.");
            }
            // O estoque do produto não pode ser negativo
            if (produto.Estoque < 0)
            {
                throw new Exception("Estoque do produto não pode ser negativo.");
            }
            //Se tudo estiver ok, chama a rotina de gravação
            idal.Incluir(produto);

        }
    }
}
