using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EC_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine("Valor da variável: " + i);
                i = i + 1;
            }
            bool repetir = true;
            int x = 0;
            while (repetir)
            {
                Console.WriteLine("Valor da variável X: " + x);
                if (x > 20)
                {
                    Console.Write("Sando do programa ");
                    repetir = false;
                }
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
