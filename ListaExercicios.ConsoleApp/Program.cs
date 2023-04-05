using Exercicio01.ConsoleApp;

namespace ListaExercicios.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa caixa = new Caixa();

            caixa.Altura = 10;
            caixa.Comprimento = 10;
            caixa.Largura = 10;

            caixa.CalcularVolume();
            Console.WriteLine("O volume da caixa é: " + caixa.Volume + " metros cúbicos.");

        }
    }
}