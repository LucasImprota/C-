using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condenação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String nome;
            Int32 idade;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            idade = Int32.Parse(Console.ReadLine());

            File.AppendAllText("dados.txt", nome + " - " + idade);

            Console.ReadKey();
        }
    }
}
