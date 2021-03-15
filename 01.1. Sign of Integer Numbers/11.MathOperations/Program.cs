using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string sign= Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, sign, secondNumber  );
            Console.WriteLine(result);
        }
        static double Calculate (double a, string sign, double b)
        {
            double result = 0;
            if (sign == "+") result = a + b;
            else if (sign == "-") result = a - b;
            else if (sign == "*") result = a * b;
            else result = a / b;
            return result;
        }
    }
}
