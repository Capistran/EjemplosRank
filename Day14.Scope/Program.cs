using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14.Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
            Console.ReadLine();
        }
    }

    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int [] arrayInt)
        {
            elements = arrayInt;
        }

        int aux = 0;
        int result = 0;
        int max = 0;
        public void computeDifference()
        {
            for (int i=0;i<elements.Length; i++)
            {
                for(int j=0;j<elements.Length;j++)
                {
                    
                        result = elements[i] - elements[j];
                        if (result > max)
                            max = result;
                        aux = result;                 
                }
            }
            maximumDifference = max;
            
        }
    }
}
