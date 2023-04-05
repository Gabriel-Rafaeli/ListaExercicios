using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08.ConsoleApp
{
    internal class LataDeOleo
    {
        public int raio { get; set; }
        public int altura { get; set; }

        public double CalcularVolume()
        {
            return Math.PI * raio * raio * altura;
        }
    }
}
