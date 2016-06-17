using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltarnantingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            string[] cadenasArr = new string[test];
            for (int i = 0; i < test; i++)
            {
                cadenasArr[i] = Console.ReadLine();
            }

            string aux = string.Empty;
            List<int> result = new List<int>();
            foreach(var cad in cadenasArr)
            {
                bool charinicial = false;
                int counter = 0;
                char[] charArr = cad.ToArray();
                aux = charArr[0].ToString();
                foreach (var ca in charArr)
                {                              
                    if (aux != string.Empty)
                    {
                        if (aux == ca.ToString()&&charinicial)
                            counter++;
                        aux = ca.ToString();
                    }
                    charinicial = true;
                }
                result.Add(counter);
            }

            foreach (var r in result)
                Console.WriteLine(r);

            Console.ReadLine();
        }
    }
}
