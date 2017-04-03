using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelos;
using System.Data;

namespace BLL
{
    public class VendasBLL : AbstractBLL
    {
        public VendasBLL() : base(new VendasDAL())
        {
        }

        private VendasDAL venda ;
        public DataTable ListaDeProdutos
        {
            get
            {
                venda = (VendasDAL)idal;
                return venda.ListaDeProdutos;
            }
        }
        public DataTable ListaDeClientes
        {
            get
            {
                venda = (VendasDAL)idal;
                return venda.ListaDeClientes;
            }
        }
        
        
        public override void Incluir(EntidadePersistente entidade)
        {
            idal.Incluir(entidade);
        }
    }
}
