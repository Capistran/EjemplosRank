using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8DictionaryMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nombresTel = new Dictionary<string, string>();
            int numeroPersonas = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < numeroPersonas; i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                
               if(!nombresTel.Keys.ToList().Exists(p=>p== arr_temp[0]))
               {
                    nombresTel.Add(arr_temp[0], arr_temp[1]);
               }               
            }
            string[] arrPersonas = new string[numeroPersonas];
            for (int j = 0; j < numeroPersonas; j++)
            {
                arrPersonas[j] = Console.ReadLine();
            }


            foreach(var at in arrPersonas)
            {
                if (nombresTel.Keys.ToList().Exists(p => p == at))
                {
                    string strValue = string.Empty;                    
                    nombresTel.TryGetValue(at, out strValue);
                    Console.WriteLine("{0}={1}", at,strValue);
                }
                else
                    Console.WriteLine("Not Found");
            }


            Console.ReadLine();


            
        }
    }
}
