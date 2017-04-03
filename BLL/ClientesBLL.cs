using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelos;

namespace BLL
{
    public class ClientesBLL : AbstractBLL
    {
        public ClientesBLL() : base(new ClientesDAL())
        {
        }

        public override void Incluir(EntidadePersistente entidade)
        {
            ClienteInformation cliente = (ClienteInformation)entidade;
            //O nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            //E-mail é sempre em letras minúsculas
            cliente.Email = cliente.Email.ToLower();

            //Se tudo está Ok, chama a rotina de inserção.
            idal.Incluir(cliente);
        }
    }
}
