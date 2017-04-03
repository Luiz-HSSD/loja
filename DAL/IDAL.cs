using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;

namespace DAL
{
    public interface IDAL
    {
         void Incluir(EntidadePersistente entidade);
         void Alterar(EntidadePersistente entidade);
         void Excluir(int codigo);
         DataTable Listagem();

    }
}
