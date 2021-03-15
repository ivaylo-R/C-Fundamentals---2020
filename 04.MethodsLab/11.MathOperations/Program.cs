using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (sign=='+')
            {
                Console.WriteLine((GetCollection(firstNum, secondNum)));
                return;
            }
            if (sign == '-')
            {
                Console.WriteLine((GetSubstraction(firstNum, secondNum)));
                return;
            }
            if (sign == '/')
            {
                Console.WriteLine((GetDivision(firstNum, secondNum)));
                return;
            }
            if (sign == '*')
            {
                Console.WriteLine((GetMultiplication(firstNum, secondNum)));
                return;
            }
        }

        private static int GetSubstraction(int a, int b)
        {
            return a - b;
        }

        static double GetCollection(int a, int b)
        {
            return a + b;
        }
        static double GetDivision(int a, int b)
        {
            return a / b;
        }
        static double GetMultiplication(int a, int b)
        {
            return a * b;
        }
    }
}
