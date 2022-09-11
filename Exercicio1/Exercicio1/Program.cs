using System;
using Exercicio1;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario s;

            s = new Salario();

            Console.WriteLine("Informe os dados");

            Console.Write("Nome: ");
            s.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            s.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            s.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {s.Nome}, R$ {s.SalarioLiquido()}" );

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double increase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s.AumentarSalario(increase);

            Console.WriteLine($"Dados atualizados: {s.Nome}, R$ {s.SalarioLiquido()}");
        }
    }
}