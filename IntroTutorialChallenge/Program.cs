using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroTutorialChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string buscar = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = new string[n];
            string chainString = Console.ReadLine();
            arr_temp = chainString.Split(new string[] { " " }, StringSplitOptions.None);
            int index = 0;
            bool existe = false;
            for(index = 0; index < n; index++)
            {
                if (arr_temp[index] == buscar)
                {
                    existe = true;                   
                    break;
                }                
            }
            
            if(existe)
                Console.WriteLine(index);
            else
                Console.WriteLine(-1);

        }
    }
}
