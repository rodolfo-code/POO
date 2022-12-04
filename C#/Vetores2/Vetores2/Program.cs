using System;
using System.Globalization;

namespace Vetores2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome do produto");
                string prod = Console.ReadLine();

                Console.Write("Preço");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = prod, Price = preco };

            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("Media é: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}