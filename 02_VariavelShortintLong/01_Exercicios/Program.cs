using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string entradaNome, EntradaIdade;
            Console.WriteLine("Digite o seu nome: ");
            entradaNome = Console.ReadLine();
            Console.WriteLine("Digite sua Idade: ");
            EntradaIdade = Console.ReadLine();
            int IdadeNumero = int.Parse(EntradaIdade);
            int AnoNascimento = DateTime.Now.Year - IdadeNumero;
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Seu Nome: " + entradaNome);
            Console.WriteLine("A ano aproximado de nascimente é: " + AnoNascimento);
            Console.ReadKey();

        }
    }
}
