using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamAndSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = Console.ReadLine();

            double result = 0;
            int lenCadena = cadena.Length;
            List<string> listaNumerosCadena = new List<string>();
            listaNumerosCadena.Add(cadena);
            string subcadena = string.Empty;
                        
            for (int i = 0; i < lenCadena; i++)
            {
                for(int j=i;j<lenCadena;j++)
                {
                     subcadena = cadena.Substring(i, lenCadena-j);
                     if (!listaNumerosCadena.Exists(p => p == subcadena) && subcadena != string.Empty)
                     {
                            listaNumerosCadena.Add(subcadena);
                     }
                }
            }

            foreach(var lst in listaNumerosCadena)
            {
                
                    var x = Convert.ToDouble(lst) % (Math.Pow(10, 9) + 7);
                    result += Convert.ToDouble(x);
                    
                
            }
           

            Console.WriteLine(result % (Math.Pow(10, 9) + 7));
            Console.ReadLine();
        }
    }
}
