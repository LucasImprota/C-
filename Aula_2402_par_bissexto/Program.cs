using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2402_par_bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double numero, resto;
            Console.WriteLine("Digite um numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            resto = numero % 2;
            if (resto == 0) { Console.WriteLine("O numero é par"); };
            if (resto != 0) { Console.WriteLine("O numero é impar"); };

            Console.ReadKey();

            Double ano, resto1;
            Console.WriteLine("Digite um numero: ");
            ano = Convert.ToDouble(Console.ReadLine());
            resto1 = ano % 4;
            if (resto1 == 0) { Console.WriteLine("O ano é bissexto"); };
            if (resto1 != 0) { Console.WriteLine("O ano não é bissexto"); };

            Console.ReadKey();
        }
    }
}
