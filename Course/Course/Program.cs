using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483647L;
            float n5 = 4.5f;
            double n6 = 4.6;
            string nome = "Maria";
            object obj1 = "Alex Brown";
            object obj2 = 4.4f;

            int min = int.MinValue;
            int max = int.MaxValue;
            sbyte smin = sbyte.MinValue;
            long lmax = long.MaxValue;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(smin);
            Console.WriteLine(lmax);

            double saldo = 10.35784;

            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}