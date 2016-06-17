using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankEjemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = new string[n];
            string chainString = Console.ReadLine();
            arr_temp=chainString.Split(new string[] { " " }, StringSplitOptions.None);
            long suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma +=Convert.ToInt64( arr_temp[i]);
            }
            Console.WriteLine(suma);

            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        }
    }
}
