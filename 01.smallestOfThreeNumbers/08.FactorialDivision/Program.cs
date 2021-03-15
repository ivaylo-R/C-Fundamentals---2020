using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double factorial = int.Parse(Console.ReadLine());
            double divider = int.Parse(Console.ReadLine());
            double firstFactorial = FindFactorial(factorial);
            double secondFactorial = FindFactorial(divider);

            double output = firstFactorial / secondFactorial;
            Console.WriteLine($"{output:F2}");
        }
        static double FindFactorial(double n)
        {
            double factorialNum = 1;
            for (double i = n; i >= 1; i--)
            {
                factorialNum *= i;

            }
            
            return factorialNum;
        }
        
    }
}
