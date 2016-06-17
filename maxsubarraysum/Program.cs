using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxsubarraysum
{
    class Program
    {
        static void Main(string[] args)
        {

            int test = Convert.ToInt32(Console.ReadLine());
            for(int t=0;t<test;t++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arregloInt = Array.ConvertAll(arr_temp, Int32.Parse);
                Console.WriteLine(MaxSum(arregloInt));
            
            }
            Console.ReadLine();
        }

        static int MaxSum(int [] array)
        {
            if (array.Length == 0) return 0; int maxSum = array[0];
            int arr = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (arr < 0)
                {
                    arr = array[i];
                }
                else
                {
                    arr += array[i];
                }
                maxSum = maxSum > arr ? maxSum : arr;
            }
            return maxSum;
        }
    }
}
