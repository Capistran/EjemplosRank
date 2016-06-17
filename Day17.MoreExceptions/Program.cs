using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17.MoreExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }

    class Calculator
    {

        public Calculator()
        { }

        public int power(int numero, int power)
        {
            if (numero < 0 || power < 0)
                throw new Exception("n and p should be non-negative");
            int resultado = 1;
            for (int i = 1; i <= power; i++)
            {
                resultado *= numero;

            }
            return resultado;
        }
    }
}
