 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_resp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[,] mat = new int[4, 3];

            for (Int32 linha = 0; linha < 4; linha++)
            {
                for (Int32 coluna = 0; coluna < 3; coluna++)
                {
                    Console.WriteLine($"Digite o dado para ({linha} - {coluna})");
                    mat[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine(mat.ToString());




            Console.ReadKey();

        }
    }
}
