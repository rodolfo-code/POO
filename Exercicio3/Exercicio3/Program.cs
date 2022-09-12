using System;
using Exercicio3;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria p;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string depositoInicial = Console.ReadLine();

            double inicial = 0;

            

            if (depositoInicial == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p = new ContaBancaria(conta, titular, inicial);
            } else
            {
                p = new ContaBancaria(conta, titular);
            }


            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(p.ToString());


            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Deposito(deposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p.ToString());

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Saque(saque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);
        }
    }
}