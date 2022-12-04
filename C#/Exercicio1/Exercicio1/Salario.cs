

namespace Exercicio1
{
    internal class Salario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double perc = (porcentagem/ 100) * SalarioBruto;
            SalarioBruto += perc;
        }

    }
}
