using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09_4_For_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double montante, taxa;
            Int32 qtdMes;

            Console.Write("Qual o montante: ");
            montante = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de meses: ");
            qtdMes = Int32.Parse(Console.ReadLine());

            Console.Write("Qual a taxa de juros ao mes: ");
            taxa= Double.Parse(Console.ReadLine());

            for (int i = 0; i < qtdMes; i++)
            {
                montante *= 1 + (taxa / 100);
                Console.Write($"Total no mês 01: {montante:f2}");
            }
             

            Console.ReadKey();
        }
    }
}
