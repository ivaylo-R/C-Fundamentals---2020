using System;

namespace _10.multiplyEvenByOdds2ndWay
{
    class Program
    {
        static void Main()
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            FindOddSum(input);
            FindEvenSum(input);
            int result = FindTotalMultiple(input);
            Console.WriteLine(result);
        }

        private static int FindTotalMultiple(int input)
        {
            return FindOddSum(input) * FindEvenSum(input);
        }

        static int FindOddSum(int input)
        {
            int sumOfOdd = 0;
            while (input != 0)
            {

                int currentDiggit = input % 10;
                if (currentDiggit % 2 == 1)
                {
                    sumOfOdd += currentDiggit;
                }
                input -= currentDiggit;
                input /= 10;

            }
            return sumOfOdd;
        }
        static int FindEvenSum(int input)
        {
            int evenSum = 0;
            while (input != 0)
            {
                int currentDigit = input % 10;
                if (currentDigit % 2 == 0)
                {
                    evenSum += currentDigit;
                }
                input -= currentDigit;
                input /= 10;
            }
            return evenSum;
        }
    }
}
