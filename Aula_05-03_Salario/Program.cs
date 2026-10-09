using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_03_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Double salario, ds, dl, da, saldo;

            Console.WriteLine("Informe seu Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe seu salario:");
            salario = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua despesa de:");
            Console.WriteLine("saude:");
            ds = Double.Parse(Console.ReadLine());
            Console.WriteLine("lazer:");
            dl = Double.Parse(Console.ReadLine()); 
            Console.WriteLine("Alimentação:");
            da = Double.Parse(Console.ReadLine());

            saldo = salario - (ds + da + dl);

            if (saldo <= 0) { Console.WriteLine("Gaste menos"); }
            if (saldo > 0 && saldo <= 3000) { Console.WriteLine("Melhor fazer uma poupança");}
            if (saldo > 3000 && saldo <= 5000) { Console.WriteLine("Sobrou bastante hein"); }
            if (saldo < 5000) { Console.WriteLine("Parabens!!!"); }
            
            Console.ReadKey();
        }
    }
}
