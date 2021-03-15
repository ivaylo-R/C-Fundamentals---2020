using System;

namespace _08.TestFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            double factorial = Factorial(number);
            PrintFactorial(factorial,number);
        }

        private static void PrintFactorial(double fact,int num)
        {
            Console.WriteLine($"factorial of {num} is {fact}");
        }

        private static double Factorial(int number)
        {
            if (number == 0) return 1;
            return number * Factorial(number - 1);
        }
    }
}
