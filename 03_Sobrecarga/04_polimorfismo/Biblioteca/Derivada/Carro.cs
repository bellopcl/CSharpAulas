using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_polimorfismo.Biblioteca.Derivada
{
    class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Carro esta se movendo! ");
            base.Mover();
        }
    }
}
