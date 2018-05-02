using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> marcas = new List<string>();

            marcas.Add("fiat");
            marcas.Add("chevrolet");
            marcas.Add("Renault");
            marcas.Add("pegeout");
            marcas.Add("Fusca");

            Console.WriteLine("Primeira Marca: " + marcas[0]);
            foreach(string marca in marcas)
            {
                Console.WriteLine("Marca: " + marca);
            }
            Console.ReadKey();
        }
    }
}
