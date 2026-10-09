using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_19_03_Nome_Minusculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, usuario;
            int Tamanho;
            Console.WriteLine("De seu nome completo para sugerirmos um apelido");
            nome = Console.ReadLine();
            nome = nome.ToLower();

            nome = nome.Trim();
            usuario = nome[0].ToString();

           int espaco = nome.LastIndexOf(' ');
            usuario = usuario + nome.Substring(espaco + 1);

            nome = nome.Replace(" ", "");
            Tamanho = nome.Length;

            usuario = usuario + Tamanho.ToString();


            Console.WriteLine(usuario);
            
            
            Console.ReadKey();
        }
    }
}
