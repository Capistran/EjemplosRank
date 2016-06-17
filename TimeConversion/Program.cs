using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string Tiempo = Console.ReadLine();
            string[] splitTiempo = Tiempo.Split(new string[] { ":" }, StringSplitOptions.None);
            int seconds = 0;
            int hour = 0;
            if (Convert.ToUInt32(splitTiempo[0]) > 12 && Convert.ToUInt32(splitTiempo[0]) > 1)
                return;
            if (char.IsLetter(splitTiempo[2], 2))
                seconds = Convert.ToInt32(splitTiempo[2].Substring(0, 2));

            if (splitTiempo[2].Substring(2, 2) == "AM")            
                hour = 0;               
            
            else if (splitTiempo[2].Substring(2, 2) == "PM")
                hour = 12;

            if (Convert.ToUInt32(splitTiempo[0]) == 12)
                splitTiempo[0] = "0";
            DateTime fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(splitTiempo[0])+hour, Convert.ToInt32(splitTiempo[1]), seconds);
            Console.WriteLine(fecha.ToString("HH:mm:ss"));
            Console.ReadLine();
        }
    }
}
