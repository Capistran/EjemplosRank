using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSpaceandCiphertextSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = Console.ReadLine();
            string result = string.Empty;
            if (cadena.Length > 10)
                return;
            char[] arrCaracter = cadena.ToArray();

            foreach (var c in arrCaracter)
            {
                string cadenaresult = (Convert.ToInt32(c.ToString())+1).ToString();
                if (cadenaresult.Length > 1)
                    cadenaresult = "0";

                result += cadenaresult;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
