namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();
            esfera.raio = 1;
            Console.WriteLine($"Volume: {esfera.CalcularVolume()}");
        }
    }
}