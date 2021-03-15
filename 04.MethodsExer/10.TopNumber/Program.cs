using System;
using System.Collections.Generic;

namespace _10.TopNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            NumsFromOneToN(n);
        }

        private static void NumsFromOneToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                bool isSumDivisibleByEight = CheckSumOfDigits(i);
                bool isHaveOneOddDigit =CheckForOddDigits(i);
                if (isSumDivisibleByEight && isHaveOneOddDigit)
                {
                    Print(i);
                }
            }
        }

        private static void Print(int num)
        {
            Console.WriteLine(num);
        }

        private static bool CheckForOddDigits(int num)
        {
            while (num!=0)
            {
                int currDigit = num % 10;
                if (currDigit%2==1)
                {
                    return true;
                }
                num /= 10;

            }
            return false;
        }

        private static bool CheckSumOfDigits(int num)
        {
            int sum = 0;
            while (num!=0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum%8==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
