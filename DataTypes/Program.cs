using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.DataTypes
{
    //https://www.hackerrank.com/challenges/30-data-types
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank";

            int i2 = Convert.ToInt32(Console.ReadLine());
            double d2 = Convert.ToDouble(Console.ReadLine());
            string s2 = Console.ReadLine();

            Console.WriteLine(i + i2);
            Console.WriteLine("{0}", (d + d2).ToString("F1"));
            Console.WriteLine(s + " " + s2);
            Console.ReadLine();
        }
    }
}
