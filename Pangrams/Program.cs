using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = Console.ReadLine();

            cadena = cadena.ToLower();
            //97-122
            int i = 0;
            int counter = 0;
            for (i= 97;i <= 122;i++)
            {
                counter++;
            }
            int numcar = counter;
            char[] arrChar = cadena.ToArray();
            List<string> letras = new List<string>();
            foreach (var c in arrChar)
            {
                if (!letras.Exists(p => p == c.ToString())&&c.ToString()!=" ")
                    letras.Add(c.ToString());
            }

            if (letras.Count == numcar)
                Console.WriteLine("PANGRAM");
            else
                Console.WriteLine("NO PANGRAM");


        }
    }
}
