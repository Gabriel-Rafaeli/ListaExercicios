using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.ConsoleApp
{
    class Cilindro
    {
        public int raio;
        public int altura;

        public double CalcularVolume()
        {
            return Math.PI * raio * raio * altura;
        }
    }
}
