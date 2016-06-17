using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                
                counter = 0;
                for (int j = arr[0]; j <= arr[1]; j++)
                {
                    double result = Math.Round(Math.Sqrt(Convert.ToDouble(j)),0);                    
                    if(j== Convert.ToInt32(Math.Pow(result,2)))// * Convert.ToInt32(result);                  
                        counter++;
                    
                }
                Console.WriteLine(counter);
            }
            Console.ReadLine();
        }
    }
}
