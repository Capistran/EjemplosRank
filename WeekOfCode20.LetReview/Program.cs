using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.LetReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
           
            for (int T = 0; T < test; T++)
            {
                string textopar = string.Empty;
                string textoimpar = string.Empty;
                char [] cadena = Console.ReadLine().ToArray();
                for(int c =0;c<cadena.Length;c++)
                {
                    if (c % 2 == 0)
                        textopar += cadena[c].ToString();
                    else
                        textoimpar+= cadena[c].ToString();
                }
                Console.WriteLine(textopar + " " + textoimpar);
            }
            
          //  Console.WriteLine(textoimpar);
            Console.ReadLine();
        }
    }
}
