using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = new string[n];
            string chainString = Console.ReadLine();
            arr_temp = chainString.Split(new string[] { " " }, StringSplitOptions.None);
            int index = 0;
            int [] arrInt = Array.ConvertAll(arr_temp, int.Parse);
            int aux = 0;
            while (index == (arr_temp.Length - 1))
            {
                for (int i = 0; i < arr_temp.Length; i++)
                {
                    aux = arrInt[i + 1];
                    if (arrInt[i] < aux)
                        arr_temp[i] = arrInt[i].ToString();
                    

                }
            }
        }
    }
}
