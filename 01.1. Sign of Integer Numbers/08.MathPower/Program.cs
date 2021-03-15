using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = Result(num, power);
            Console.WriteLine(result);
        }
        static double Result(double num, double power)
        {
            return Math.Pow(num, power);
        }
    }
}
