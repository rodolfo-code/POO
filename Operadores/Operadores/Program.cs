using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "rodolfo vinicius oliveira";
            string[] vet = s.Split(' ');


            //double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = Maior(8, 2, 3);

            Console.WriteLine(resultado);
        }

        static int Maior(int a, int b, int c)
        {
            int maior = a;

            int[] v = {a, b, c};
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > maior)
                {
                    maior = v[i];
                }
            }

            return maior;

        }
    }
}