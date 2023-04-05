namespace Exercicio04.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.kmInicial = 10;
            carro.kmFinal = 260;
            carro.consumoCombustivel = 50;

            Console.WriteLine($"Consumo total: {carro.CalcularConsumo()}");
        }
    }
}