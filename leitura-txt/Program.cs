using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leitura_txt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = new string[5];

            for (int pos = 0; pos < nomes.Length; pos++)
            {
                Console.Write($"Digite o {pos+1}° nome: ");
                nomes[pos] = Console.ReadLine();
            }

            for (int pos = 0; pos < nomes.Length; pos++)
            {
                Console.WriteLine($"Nome -> {nomes[pos]}");
            }


            Console.ReadKey();
        }
    }
}
