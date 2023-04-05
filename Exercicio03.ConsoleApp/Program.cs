namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            cilindro.raio = 3;
            cilindro.altura = 2;

            Console.WriteLine($"Volume Cilindro: {cilindro.CalcularVolume()}");
        }
    }
}
