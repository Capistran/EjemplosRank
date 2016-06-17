using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler6
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<test;i++)
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                int diferencia = 0;
                double suma = 0;
                double sumpower = 0;
                for(int j=1;j<=numero;j++)
                {
                    suma += Math.Pow(Convert.ToDouble(j), 2);
                    sumpower += j;
                }
                Console.WriteLine(Math.Pow(Convert.ToDouble(sumpower), 2)  - suma);
            }

            Console.ReadLine();
        }
    }
}
