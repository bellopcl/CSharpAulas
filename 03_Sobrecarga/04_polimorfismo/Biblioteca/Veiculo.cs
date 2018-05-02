using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_polimorfismo
{
    class Veiculo
    {
        public string Marca;
        public string Modelo;
        public string ano;

        public virtual void Mover()
        {
            Console.WriteLine("Veiculo se movendo");
        }
    }
}
