using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Calculator.Sum( 2, 3 );
            int sum2 = Calculator.Sum( 3, 3, 3 );

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}