using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for(int i=0;i<test;i++)
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                counter = 0;
                foreach(var num in numero.ToString().ToArray())
                {
                    if(num.ToString()!="0")
                    {
                        if(numero%Convert.ToInt32(num.ToString())==0)
                            counter++;
                    }
                }

                Console.WriteLine(counter);
            }

            Console.ReadLine();
        }
    }
}
