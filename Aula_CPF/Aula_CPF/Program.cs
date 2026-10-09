using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Aula_CPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, cpf;
            Int32 idade;
            Single salario;

            //Receber Dados

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            cpf = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            //Descobre o primeiro nome

            int espaco = nome.IndexOf(' ');
            String PriNome;
            if (espaco != -1) { PriNome = nome.Substring(0, espaco); }
            else { PriNome = "O nome não é composto!!!"; }

            int tamanho = nome.Length;
            String letras = nome.Substring(tamanho-3);


            //Exibir dados

            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Primeiro NOME: {PriNome}");
            Console.WriteLine($"Ultimas 3 letras; {letras}");


            Console.ReadKey();
        }
    }
}
