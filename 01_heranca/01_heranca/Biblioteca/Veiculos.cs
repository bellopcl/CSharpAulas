using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_heranca.Biblioteca
{
    class Veiculos
    {
        public string Marca;
        public string Modelo;
        public int QuantidadeMaxPassageiros;
        public int Ano;

        public void Mover()
        {
            Console.WriteLine("Mover Chamado dentro de: Veiculo.Mover");
        }
    }
}
