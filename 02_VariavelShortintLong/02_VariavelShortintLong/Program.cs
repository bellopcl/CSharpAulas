using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VariavelShortintLong
{
    class Program
    {
        static void Main(string[] args)
        {
            short meuShort = 10;
            System.Int16 meuShort2 = 20;

            int meuInt;
            long meuLong;
            char meuChar = 'A';
            string minhaString = "Qualquer coisa que eu queira.";
            //converter numeros para inteiros
            string NumeroTexto = "30";
            int numero1 = int.Parse(NumeroTexto);
            int numero2 = 30;

            Console.Write("o Resultado da Some é: " + (numero1 + numero2));

            //Console.Write(meuShort + meuShort2);
            //Console.Write(minhaString);
            Console.ReadKey();
        }
    }
}
