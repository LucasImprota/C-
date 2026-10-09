using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1902_CalculoMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float p1, p2, p3, media;
            
            Console.WriteLine("Digite o valor de sua primeira prova");
            p1 = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de sua segunda prova");
            p2 = Single.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de sua terceira prova");
            p3 = float.Parse(Console.ReadLine());
            
            media = (p1 + p2 + p3)/3;
            Console.WriteLine("A valor da media das suas provas é: {0}",media);


            Console.ReadKey();
        }
    }
}
