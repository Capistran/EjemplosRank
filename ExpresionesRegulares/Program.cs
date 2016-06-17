using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Lets use a regular expression to match a date string.
            //string pattern = @"([a-zA-Z]+) (\d+)";

            //// The RegexOptions are optional to this call, we will go into more detail about
            //// them below.
            //Match result = Regex.Match("June 24", pattern);
            //if (result.Success)
            //{
            //    // Indeed, the expression "([a-zA-Z]+) (\d+)" matches the date string

            //    // To get the indices of the match, you can read the Match object's
            //    // Index and Length values.
            //    // This will print [0, 7], since it matches at the beginning and end of the 
            //    // string
            //    Console.WriteLine("Match at index [{0}, {1})",
            //        result.Index,
            //        result.Index + result.Length);

            //    // To get the fully matched text, you can read the Match object's Value
            //    // This will print "June 24"
            //    Console.WriteLine("Match: {0}", result.Value);

            //    // If you want to iterate over each of the matches, you can call the 
            //    // Match object's NextMatch() method which will return the next Match
            //    // object.
            //    // This will print out each of the matches sequentially.
            //    while (result.Success)
            //    {
            //        Console.WriteLine("Match: {0}", result.Value);
            //        result = result.NextMatch();
            //    }



            string patron = @"^\d{2}$";
            string cadena = "1aAZz3";
            Match resultado = Regex.Match(cadena, patron);
            if(resultado.Success)
            {
                Console.WriteLine(resultado.Groups["word"].Value);
                Console.WriteLine(resultado.Value);
                Console.ReadLine();
            }
                

           
        }
    }
}
