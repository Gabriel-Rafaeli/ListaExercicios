using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.ConsoleApp
{
    class Temperatura
    {
        public int grauFahrenheit;

        public double ConverteGrauFarenheitCelsius()
        {
            return (grauFahrenheit - 32) / 1.8;
        }
    }
}
