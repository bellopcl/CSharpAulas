using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ConversaoNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            short meuShort = 10;
            int meuInt = meuShort;
            long meuLong = meuInt;

            long meuLong2 = 10;
            int meuInt2 = Convert.ToInt32(meuLong2);
            short meuShort2 = Convert.ToInt16(meuInt2);

            //Array

            string[] nomes = {"João da Silva", "Jose da Costa", "Maria da Costa"};
            Console.Write("Nome de N3: " + nomes[2]);
            nomes[2] = "Miguel da costa";
            Console.Write("Nome de N3: " + nomes[2]);
            Console.ReadKey();

        }
    }
}
