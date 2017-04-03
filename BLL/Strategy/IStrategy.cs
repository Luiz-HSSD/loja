using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace BLL.Strategy
{
    interface IStrategy
    {
        string Processar(EntidadePersistente entidade);
    }
}
