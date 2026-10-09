using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2402_Concatenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome, sobrenome, junto;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            junto = (nome + " " + sobrenome);

            Console.WriteLine($"Olá {junto}");

            Console.ReadKey(); 

        }
    }
}
