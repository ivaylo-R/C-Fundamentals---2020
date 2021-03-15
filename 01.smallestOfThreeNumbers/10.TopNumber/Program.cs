using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumbersUpTo(number);
        }

        private static void PrintTopNumbersUpTo(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                if (SumOfDigitsIsDivisibleBy8(i) && isAlavailableOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool isAlavailableOddDigit(int num)
        {
            while (num>0)
            {
                if ((num%10)%2==1)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }

        private static bool SumOfDigitsIsDivisibleBy8(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum%8==0)
            {
                return true;
            }
            return false;
        }
    }
}