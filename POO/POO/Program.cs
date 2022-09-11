using System;
using System.Globalization;
using POO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
        
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            double areax = x.Area();
            double areay = y.Area();

            Console.WriteLine("Area de X = " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areay.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}