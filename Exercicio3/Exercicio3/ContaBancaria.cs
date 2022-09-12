using System.Globalization;

namespace Exercicio3
{
    internal class ContaBancaria
    {

        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double ValorTotalEmConta { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double inicial) : this(numeroConta, nomeTitular)
        {
            ValorTotalEmConta = inicial;
        }

        public void Deposito(double deposito)
        {
            ValorTotalEmConta += deposito;
        }

        public void Saque(double saque)
        {
            ValorTotalEmConta -= (saque + 5.00);
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + NomeTitular
                + ", Saldo: R$ "
                + ValorTotalEmConta.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
