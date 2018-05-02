using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_classe
{
    class Carro
    {
        public string marca = "Fiat";
        public string modelo;
        public string cor;
        public bool LuzesInternas = false;

        public void AbrirPorta()
        {
            LuzesInternas = true;
        }

        public void FecharPorta()
        {
            LuzesInternas = false;
        }

        public string AcenderFarolAutomaticamente()
        {
            return "Médio";
        }
    }
}
