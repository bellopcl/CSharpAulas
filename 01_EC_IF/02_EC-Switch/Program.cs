using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EC_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu estado civil? (informe: S - Solteiro, C - Casado, V - Viuvo, D - Divorciado)");
            string valor = Console.ReadLine();
            switch (valor)
            {
                case "S":
                    Console.WriteLine("Você esta solteiro, deseja encontrar alguêm?");
                    break;
                case "C":
                    Console.WriteLine("Voce esta casado, parabens!");
                    break;
                case "V":
                    Console.WriteLine("Você esta viuvo");
                    break;
                 case "D":
                    Console.WriteLine("Você esta divorciado!");
                    break;
                default:
                    Console.WriteLine("Opção não definida!");
                    break;
            }
        }
    }
}
