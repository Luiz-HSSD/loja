using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;

namespace BLL.aplicacão
{
    public class Resultado:EntidadeAplicação
    {
        private string msg;
        private List<EntidadePersistente> entidades;
        private DataTable listagem;
        public DataTable Listagem
        {
            get { return listagem; }
            set { listagem = value; }
        }
        public List<EntidadePersistente> Entidades
        {
            get { return entidades; }
            set { entidades = value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }

    }
}
