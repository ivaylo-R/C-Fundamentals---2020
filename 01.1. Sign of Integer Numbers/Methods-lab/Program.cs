using System;

namespace Methods_lab
{
    class Program
    {
        static void Main()
        {
            PrintSign(int.Parse(Console.ReadLine()));

        }

        static void PrintSign(int num)
        {
            if (num > 0)
                Console.WriteLine($"The number {num} is possitive. ");
            else if (num < 0)
                Console.WriteLine($"The number {num} is negative.");
            else 
            Console.WriteLine($"The number {num} is zero.");
        }

    }
}
