using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Arrays
{
    //https://www.hackerrank.com/challenges/30-arrays
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            string reverse = string.Empty;

            for(int i=arr.Length-1;i>=0;i--)
            {
                reverse += arr[i].ToString() + " ";
            }
            reverse = reverse.Remove(reverse.Length - 1, 1);

            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}
