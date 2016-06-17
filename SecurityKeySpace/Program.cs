using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityKeySpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            string secCadena = string.Empty;
            foreach(var c in cadena.ToArray())
            {
                var resultado = Convert.ToInt32(c.ToString()) + num;
                if (resultado > 9)
                    resultado =Convert.ToInt32(resultado.ToString().Substring(1,1));
                
                secCadena += resultado.ToString();

            }
            Console.WriteLine(secCadena);
            Console.ReadLine();
        }
    }
}
