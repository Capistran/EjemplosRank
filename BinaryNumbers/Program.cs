using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            int numero = Num;
            string cad = string.Empty;
            if (Num > 0)
            {
                
                while (Num > 0)
                {
                    if (Num % 2 == 0)                    
                        cad = "0" + cad;                    
                    else                    
                        cad = "1" + cad;
                    
                    Num = (int)(Num / 2);
                }
                //Console.WriteLine(cad);
            }
            else
            {
                if (Num == 0)                
                    Console.WriteLine("0");                               
            }

            
            int counterbin = 0;
            char caracter = '1';
            char aux = ' ';
            foreach (var c in cad.ToArray())
            {
                if (c == caracter)
                    counterbin++;
                
                aux = c;
            }

            Console.WriteLine(counterbin);
            
            Console.ReadLine();
        }
    }
}
