using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = new string[n];
            string chainString = Console.ReadLine();
            arr_temp = chainString.Split(new string[] { " " }, StringSplitOptions.None);
            decimal _pos=0, _neg=0, _zero=0,_res=0;
            //decimal _res = 0;
            decimal[] arr_int = Array.ConvertAll(arr_temp,decimal.Parse);
            foreach (var a in arr_int)
            {
                if (a == 0)
                    _zero++;
                if (a < 0)
                    _neg++;
                if (a > 0)
                    _pos++;
            }
            
            
                _res = _pos / n;
                Console.WriteLine("{0}", _res.ToString("N6"));// +n.ToString()));
            
            
                _res = _neg / n;
                Console.WriteLine("{0}", _res.ToString("N6"));// + n.ToString()));
            
            
                _res = _zero / n;
                Console.WriteLine("{0}", _res.ToString("N6"));// + n.ToString()));
           
            Console.ReadLine();

        }
    }
}
