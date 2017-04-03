using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IBLL
    {
        void Incluir(EntidadePersistente entidade);
        void Alterar(EntidadePersistente entidade);
        void Excluir(int codigo);
        DataTable Listagem();
    }
}
