using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.IntrotoConditionalStatements
{
    //https://www.hackerrank.com/challenges/30-conditional-statements
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 1 || (N >= 6 && N <= 20))            
                Console.WriteLine("Weird");
            else
                Console.WriteLine("Not Weird");
        }
    }
}
