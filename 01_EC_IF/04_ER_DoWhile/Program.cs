using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ER_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = false;
            while (repetir)
            {
                Console.WriteLine("Entrou no \"fluxo\" do While");
            }

            do
            {
                Console.WriteLine("Entrou no fluxo do - while");
            } while (repetir);
            Console.ReadKey();
        }
    }
}
