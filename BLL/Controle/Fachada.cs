using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using BLL.Strategy;
using DAL;
using BLL.aplicacão;

namespace BLL.Controle
{
    public class Fachada : IFachada
    {
        private Resultado resultado;
        private Dictionary<string, Dictionary<string, List<IStrategy>>> rns;
        private Dictionary<string, IDAL> dals;
        public Fachada()
        {
            dals = new Dictionary<string, IDAL>();
            /* Intânciando o Map de Regras de Negócio */
            rns = new Dictionary<string, Dictionary<string, List<IStrategy>>>();

            ParametroExcluir para_ex = new ParametroExcluir();
            ClientesDAL cliDAL = new ClientesDAL();
            dals.Add(typeof(ClienteInformation).Name, cliDAL);
            List<IStrategy> rnsSalvarClienteInformation = new List<IStrategy>();
            List<IStrategy> rnsAlterarClienteInformation = new List<IStrategy>();
            List<IStrategy> rnsExcluirClienteInformation = new List<IStrategy>();
            rnsExcluirClienteInformation.Add(para_ex);
            List<IStrategy> rnsConsultarClienteInformation = new List<IStrategy>();
            Dictionary<string, List<IStrategy>> rnsClienteInformation = new Dictionary<string, List<IStrategy>>();
            rnsClienteInformation.Add("SALVAR", rnsSalvarClienteInformation);
            rnsClienteInformation.Add("ALTERAR", rnsAlterarClienteInformation);
            rnsClienteInformation.Add("EXCLUIR", rnsExcluirClienteInformation);
            rnsClienteInformation.Add("CONSULTAR", rnsConsultarClienteInformation);
            rns.Add(typeof(ClienteInformation).Name, rnsClienteInformation);
        }
        private string executarRegras(EntidadePersistente entidade, string operacao)
        {
            string nmClasse = entidade.GetType().Name;
            StringBuilder msg = new StringBuilder();

            Dictionary<string, List<IStrategy>> regrasOperacao = rns[nmClasse];


            if (regrasOperacao != null)
            {
                List<IStrategy> regras = regrasOperacao[operacao];

                if (regras != null)
                {
                    foreach (IStrategy s in regras)
                    {
                        string m = s.Processar(entidade);

                        if (m != null)
                        {
                            msg.Append(m);
                            msg.Append("\n");
                        }
                    }
                }

            }

            if (msg.Length > 0)
                return msg.ToString();
            else
                return null;


        }

        public Resultado alterar(EntidadePersistente entidade)
        {
            resultado = new Resultado();
            string nmClasse = entidade.GetType().Name;

            string msg = executarRegras(entidade, "SALVAR");


            if (msg == null)
            {
                IDAL dao = dals[nmClasse];

                dao.Alterar(entidade);
                List<EntidadePersistente> entidades = new List<EntidadePersistente>();
                entidades.Add(entidade);
                resultado.Entidades = entidades;

            }
            else
            {
                resultado.Msg = msg;


            }

            return resultado;
        }

        public Resultado consultar(EntidadePersistente entidade)
        {
            resultado = new Resultado();
            string nmClasse = entidade.GetType().Name;

            string msg = executarRegras(entidade, "SALVAR");


            if (msg == null)
            {
                IDAL dao = dals[nmClasse];

                resultado.Listagem=dao.Listagem();
                List<EntidadePersistente> entidades = new List<EntidadePersistente>();
                entidades.Add(entidade);
                resultado.Entidades = entidades;

            }
            else
            {
                resultado.Msg = msg;


            }

            return resultado;
        }

        public Resultado excluir(EntidadePersistente entidade)
        {
            resultado = new Resultado();
            string nmClasse = entidade.GetType().Name;

            string msg = executarRegras(entidade, "SALVAR");


            if (msg == null)
            {
                IDAL dao = dals[nmClasse];

                dao.Excluir(entidade.Codigo);
                List<EntidadePersistente> entidades = new List<EntidadePersistente>();
                entidades.Add(entidade);
                resultado.Entidades = entidades;

            }
            else
            {
                resultado.Msg = msg;


            }

            return resultado;
        }

        public Resultado salvar(EntidadePersistente entidade)
        {
            resultado = new Resultado();
            string nmClasse = entidade.GetType().Name;

            string msg = executarRegras(entidade, "SALVAR");


            if (msg == null)
            {
                IDAL dao = dals[nmClasse];

                dao.Incluir(entidade);
                List<EntidadePersistente> entidades = new List<EntidadePersistente>();
                entidades.Add(entidade);
                resultado.Entidades = entidades;

            }
            else
            {
                resultado.Msg = msg;


            }

            return resultado;
        }
    }
}
