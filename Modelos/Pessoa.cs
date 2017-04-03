using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Pessoa:EntidadePersistente
    {
        private string email;
        private string telefone;
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Pessoa()
        {
            Telefone = "";
            Email = "";
        }
    }
}
