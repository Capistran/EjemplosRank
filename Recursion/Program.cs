using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {           
            int facto = 1;
            int numero = Convert.ToInt32(System.Console.ReadLine());
            for (int i = 1; i < numero + 1; i++)
            {
                facto = facto * i;
            }
            Console.WriteLine(facto);
            Console.ReadLine();
        }
    }
}
