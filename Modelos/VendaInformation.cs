using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class VendaInformation:EntidadePersistente
    {
        private DateTime _data;
        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }
        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        private bool _faturado;
        public bool Faturado
        {
            get { return _faturado; }
            set { _faturado = value; }
        }
        private ClienteInformation _cliente;
        public ClienteInformation Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        private ProdutoInformation _produto;
        public ProdutoInformation Produto
        {
            get { return _produto; }
            set { _produto = value; }
        }
    }
}
