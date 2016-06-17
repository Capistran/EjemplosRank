using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Operators
{
    //https://www.hackerrank.com/challenges/30-operators
    class Program
    {
        static void Main(string[] args)
        {
            double costMeal = Convert.ToDouble(Console.ReadLine());
            int tips = Convert.ToInt32(Console.ReadLine());
            int tax = Convert.ToInt32(Console.ReadLine());          

            double percenttip = costMeal * tips / 100;
            double percenttax = costMeal * tax / 100;

            costMeal = costMeal + percenttip + percenttax;

            Console.WriteLine(Convert.ToInt32(costMeal));

            Console.ReadLine();
        }
    }
}
