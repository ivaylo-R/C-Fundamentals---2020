using System;

namespace _04.MethodsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNum(n);
        }

        private static void PrintNum(int x)
        {
            if (x > 0)
            {
                Console.WriteLine($"The number {x} is positive.");
            }
            else if (x<0)
            {
                Console.WriteLine($"The number {x} is negative.");
            }
            else if (x==0)
            {
                Console.WriteLine($"The number {x} is zero.");
            }
        }
    }
}
