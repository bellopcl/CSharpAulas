using _01_heranca.Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Moto moto = new Moto();
            Veiculos vei = new Veiculos();

            carro.Marca = "Fiat";
            moto.Marca = "Honda";
            vei.Marca = "Qualquer Coisa";

            carro.Mover();
            moto.Mover();
            vei.Mover();

            Console.ReadKey();

        }
    }
}
