using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using DAL;

namespace BLL
{
    public abstract class AbstractBLL : IBLL
    {
         
        protected IDAL idal;
        public virtual void Alterar(EntidadePersistente entidade)
        {
            idal.Alterar(entidade);
        }
        public virtual void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de excluí-lo.");
            }
            idal.Excluir(codigo);
        }
        public abstract void Incluir(EntidadePersistente entidade);
        public virtual DataTable Listagem()
        {
            return idal.Listagem();
        }

        public AbstractBLL(IDAL idal)
        {
            this.idal = idal;
        }
    }
}
