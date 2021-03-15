using System;

namespace _08.factorialDivision
{
    class Program
    {
        static void Main()
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());


            Console.WriteLine($"{DivideFactorials(Factorials(y), Factorials(x)):F2}");
        }

        private static decimal DivideFactorials(decimal v1, decimal v2)
        {
            return v2 / v1;
        }

        private static decimal Factorials(decimal x)
        {
            for (decimal i = x - 1; i > 0; i--)
            {
                x *= i;
            }
            return x;
        }

    }
}
