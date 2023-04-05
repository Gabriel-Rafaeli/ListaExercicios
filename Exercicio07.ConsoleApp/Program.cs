namespace Exercicio07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salarioVendedor = new Salario();

            salarioVendedor.SalarioBase = 2000;
            salarioVendedor.Comissao = 10;
            salarioVendedor.TotalVendas = 3;
            salarioVendedor.CalcularSalarioTotal();

            Console.WriteLine("O salário total do vendedor é: R$ " + salarioVendedor.SalarioTotal);
        }
    }
}