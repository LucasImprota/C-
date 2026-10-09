using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2402_conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, F;

            Console.WriteLine("Qual valor voce quer converter :");
            C = Convert.ToDouble(Console.ReadLine());

            F = (C * 1.8 + 32);
            Console.WriteLine($"O resultado é :{F}");

            if (F >= 108) { Console.WriteLine("Hoje está quente"); };


            Console.ReadKey();
        
        }
    }
}
