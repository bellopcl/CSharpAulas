using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca.Derivada.Carro carro = new Biblioteca.Derivada.Carro();
            MoverVeiculo(carro);

            Console.ReadKey();

        }
        public static void MoverVeiculo(Biblioteca.Derivada.Carro veiculo)
        {
            veiculo.Mover();
        }

        public static void MoverVeiculo(Biblioteca.Derivada.Moto veiculo)
        {
            veiculo.Mover();
        }
        public static void MoverVeiculo(Biblioteca.Derivada.Onibus veiculo)
        {
            veiculo.Mover();
        }
    }
}
