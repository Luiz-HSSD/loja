using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace BLL.Strategy
{
    class ParametroExcluir : IStrategy
    {
        public string Processar(EntidadePersistente entidade)
        {
            if (entidade.Codigo < 1)

                return ("Selecione um cliente antes de excluí-lo.");
            
            return null;
        }
    }
}
