using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            Carro carro2 = new Carro();

            Console.WriteLine("Marca: " + carro1.marca);
            carro1.marca = "Ford";
            Console.WriteLine("Marca: " + carro1.marca);

            Console.WriteLine("Luzes Internas: " + carro1.LuzesInternas);
            carro1.AbrirPorta();
            Console.WriteLine("Luzes Internas: " + carro1.LuzesInternas);
            carro1.AcenderFarolAutomaticamente();
            string statusFarol = carro1.AcenderFarolAutomaticamente();
            Console.WriteLine("Estatus farol: " + statusFarol);
            Console.ReadKey();  
        }
    }
}
