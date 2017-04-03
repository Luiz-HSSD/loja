using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using BLL.aplicacão;
namespace BLL.Controle
{
    interface IFachada
    {
        Resultado salvar(EntidadePersistente entidade);
        Resultado alterar(EntidadePersistente entidade);
        Resultado excluir(EntidadePersistente entidade);
        Resultado consultar(EntidadePersistente entidade);
    }
}
