
namespace Exercicio07.ConsoleApp
{
    internal class Salario
    {
        public double SalarioBase { get; set; }
        public double TotalVendas { get; set; }
        public double Comissao { get; set; }
        public double SalarioTotal { get; set; }

        public void CalcularSalarioTotal()
        {
            SalarioTotal = SalarioBase + (TotalVendas * (Comissao * SalarioBase / 100));
        }
    }
}
