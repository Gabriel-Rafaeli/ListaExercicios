using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.ConsoleApp
{
    internal class Caixa
    {
        public double Altura { get; set; }
        public double Comprimento { get; set; }
        public double Largura { get; set; }
        public double Volume { get; set; }

        public void CalcularVolume()
        {
            Volume = Comprimento * Largura * Altura;
        }
    }
}
