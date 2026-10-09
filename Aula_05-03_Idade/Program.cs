using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_03_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Qual o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o sua idade");
            idade = int.Parse(Console.ReadLine());

            if (idade < 0)
            {
                Console.WriteLine("Idade impossivel");
            }
            else
                Console.WriteLine("Ola {0}, a sua idade é {1}", nome, idade);

            if (idade == 0) { Console.WriteLine("Sua faixa etária é: bebe"); }
            if (idade > 0 && idade <= 12) { Console.WriteLine("Sua faixa etária é: criança"); }
            if (idade > 12 && idade <= 18) { Console.WriteLine("Sua faixa etária é adolescente"); }
            if (idade > 18 && idade <= 60) { Console.WriteLine("Sua faixa etária é adulto"); }
            if (idade > 60 && idade <= 120) { Console.WriteLine("Sua faixa etária é idoso"); }
            if (idade > 120) { Console.WriteLine("Sua faixa etária é mumia"); }

            Console.ReadKey();
        }
    }
}
