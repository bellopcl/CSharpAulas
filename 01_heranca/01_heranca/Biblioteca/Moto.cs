using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_heranca.Biblioteca
{
    class Moto : Veiculos
    {
        public override void Mover()
        {
            Console.WriteLine("Mover chamdo dentro de Moto.Mover");
            base.Mover();
        }
    }
}
