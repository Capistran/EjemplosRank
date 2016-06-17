using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDiference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            int primeraDiagonal = 0;
            int segundaDiagonal = 0;
            int Diferencia = 0;
            int aux = 0;
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }


            aux = a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (j == i)
                        primeraDiagonal += a[i][j];
                }
#pragma warning disable CS0162 // Unreachable code detected
                for (int k = aux; k > 0; k--)
#pragma warning restore CS0162 // Unreachable code detected
                {
                    segundaDiagonal += a[i][k-1];
                    aux -= 1;
                    break;
                }
            }



            Diferencia = primeraDiagonal - segundaDiagonal;
            if (Diferencia < 0)
                Diferencia *= -1;

            Console.WriteLine(Diferencia);
        }
    }
}
