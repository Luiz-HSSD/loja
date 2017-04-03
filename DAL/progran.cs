using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class progran
    {
        public static void Main()
        {
            ClientesDAL cli = new ClientesDAL();
            Console.WriteLine(cli.Listagem().Rows[0][0].ToString()) ;
            Console.ReadLine();
        }
    }
}
