using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12_03_Genero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float salario;
            char sexo;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu salário:");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite seu gernero: (M/F)");
            sexo = Console.ReadLine()[0];

            Console.WriteLine($"Olá Sr. {nome}, seu salário é {salario:C2}");

            if (sexo == 'M' || sexo == 'm') { Console.WriteLine("Seu sexo é masculino"); }
            else if (sexo == 'F' || sexo == 'f') { Console.WriteLine("Seu sexo é feminino"); }
            else { Console.WriteLine("Informação desconhecida"); }


            if (salario == 0) { Console.WriteLine("Fálido..."); }
            else if (salario <= 5000) { Console.WriteLine("Marajá"); }
            else { Console.WriteLine("Politico"); }

            Console.ReadKey();

        }
    }
}
