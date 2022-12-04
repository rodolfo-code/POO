using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Calculator
    {
        public static int Sum(params int[] Numbers)
        {
            int sum = 0;

            for (int i = 0; i < Numbers.Length; i++)
            {
                sum += Numbers[i];
            }

            return sum;
        }
    }
}
