using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16.ExceptionsString
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int msg = 0;
            Console.WriteLine(int.TryParse(S, out msg) == true ? S : "Bad String");
            Console.ReadLine();
        }
    }
}
