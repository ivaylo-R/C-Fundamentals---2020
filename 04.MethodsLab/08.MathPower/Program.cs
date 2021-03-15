using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerTheN(n, power));
        }

        private static double PowerTheN(int n, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= n;
            }
            return result;
        }
    }
}
