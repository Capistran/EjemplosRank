using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOfCode20.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
                {
                Console.WriteLine("{0} x {1} = {2}",N,i,(N*i));
            }
            Console.ReadLine();
        }
    }
}
