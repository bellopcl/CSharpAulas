using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ER_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Jose", "Maria", "João", "Pedro", "Tiago" };
            Console.WriteLine("-----------Repetição com For");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome: " + nomes[i]);
            }

            Console.WriteLine("-----------Repetição com ForEach");
            foreach(string nome in nomes)
            {
                Console.WriteLine("Nomes: " + nome);
            }

            Console.ReadKey();
        }
    }
}
