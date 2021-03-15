using System;

namespace _05.Msign
{
    class Program
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            ResultIsPossitive(num1, num2, num3);
            ResultZero(num1, num2, num3);
            ResultNegative(num1, num2, num3);
        }

        private static void ResultNegative(double a, double d, double q)
        {
            if (a < 0 || d < 0 || q < 0)
            {
                Console.WriteLine("negative");
            }
            if ((a < 0 && d < 0 && q > 0) || (a < 0 && d > 0 && q < 0) || (a > 0 && d < 0 && q < 0))
            {
                Console.WriteLine("positive");
            }
        }

        private static void ResultZero(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("zero");
            }
        }

        private static void ResultIsPossitive(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("positive");
            }
        }
    }
}
