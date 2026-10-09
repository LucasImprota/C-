using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2602_aumento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double salario, tempo, aumento;

            Console.WriteLine("Qual o seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quanto anos trabalhou conosco: ");
            tempo = Convert.ToDouble(Console.ReadLine());

            if (salario > 2000)
                aumento = salario * 1.05;
            else
                if (tempo < 10)
                aumento = salario * 1.1;
            else
                aumento = salario * 1.15;

            Console.WriteLine("O seu novo salario é {0}",aumento);


            Console.ReadKey();
        }
    }
}
