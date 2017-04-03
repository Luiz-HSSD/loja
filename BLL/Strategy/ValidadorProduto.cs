using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace BLL.Strategy
{
    public class ValidadorProduto : IStrategy
    {
        public string Processar(EntidadePersistente entidade)
        {
            ProdutoInformation produto = (ProdutoInformation)entidade;
            // Nome do produto é obrigatório
            if (produto.Nome.Trim().Length == 0)
            {
                return ("O nome do produto é obrigatório.");
            }
            // O preço do produto não pode ser negativo
            if (produto.Preco < 0)
            {
                return ("Preço do produto não pode ser negativo.");
            }
            // O estoque do produto não pode ser negativo
            if (produto.Estoque < 0)
            {
                return ("Estoque do produto não pode ser negativo.");
            }
            return null;
        }
    }
}
