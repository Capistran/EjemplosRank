using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOfCode20.DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int suma = 0;        
            int valj = 0;
            List<int> numeros = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (i < j)
                    {
                        suma = Convert.ToInt32(a_temp[i]) + Convert.ToInt32(a_temp[j]);
                        if (suma % k == 0&& numeros.Exists(p => p == j))                        
                            valj = j;                          
                        
                        numeros.Add(j);
                    }                  
                }
            }
        

            Console.WriteLine(valj);
            Console.ReadLine();
        }
    }
}
