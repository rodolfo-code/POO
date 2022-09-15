using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;

            //ou

            double? y = 10.00;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            Console.WriteLine(y.Value);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            // Operador de coalescência nula

            double? w = null;
            double? z = 10.00;

            double a = w ?? 5;
            double b = z ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}