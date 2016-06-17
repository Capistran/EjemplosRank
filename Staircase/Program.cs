using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int hg = Convert.ToInt32(Console.ReadLine());
            string space =string.Empty;
            string staircase = "#";
            for (int i = 1; i <= hg; i++)
            {
                space = string.Empty;               
                for (int k = 1; k <=hg - i; k++)
                {
                    space += " ";
                }
               
                Console.WriteLine(space + staircase);
                staircase += "#";
            }
            Console.ReadLine();
        }
    }
}
