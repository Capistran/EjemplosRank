using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int[] multiples = { 3, 5 };
            int suma = 0;


            for (int i = 0; i < test; i++)
            {
                suma = 0;
                int numero = Convert.ToInt32(Console.ReadLine());
                for (int k = 0; k < numero; k++)
                {
                    for (int j = 0; j < multiples.Length; j++)
                    {
                        if (k % multiples[j] == 0)
                        {
                            suma += k;
                            break;
                        }
                    }
                }

                Console.WriteLine(suma);
            }

            Console.ReadLine();
                
        }
    }
}
