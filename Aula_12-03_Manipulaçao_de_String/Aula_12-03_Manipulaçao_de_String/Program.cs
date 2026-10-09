using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12_03_Manipulaçao_de_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String texto = "Fundação Salvador Arena";

            Int32 tamanho = texto.Length;

            Console.WriteLine("1° caractere é: {0}", texto[0]);

            Console.WriteLine("Ultimo caractere é: {0}", texto[tamanho - 1]);




            Console.ReadKey();
        }
    }
}
