using System;
using System.Numerics;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            for (long i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string leftNumAsString = string.Empty;
                string rightNumAsString = string.Empty;
                BigInteger sumOfLeftDigits = 0;
                BigInteger sumOfRightDigits = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    char left = numbers[j];
                    leftNumAsString += left;
                    if (left == ' ')
                    {
                        break;
                    }

                }
                for (int k = leftNumAsString.Length; k < numbers.Length; k++)
                {
                    char right = numbers[k];
                    rightNumAsString += right;
                    if (right == ' ')
                    {
                        break;
                    }
                }
                long leftN = long.Parse(leftNumAsString);
                long rightN = long.Parse(rightNumAsString);
                long leftNum = Math.Abs(leftN);
                long rightNum = Math.Abs(rightN);
                if (rightNum > leftNum)
                {
                    while (rightNum > 0)
                    {
                        BigInteger currentDigit = rightNum % 10;
                        sumOfRightDigits += currentDigit;
                        rightNum /= 10;

                    }
                    Console.WriteLine(sumOfRightDigits);
                    continue;
                }
                else
                {
                    while (leftNum > 0)
                    {
                        BigInteger currentDigit = leftNum % 10;
                        sumOfLeftDigits+= currentDigit;
                        leftNum /= 10;
                    }
                    Console.WriteLine(sumOfLeftDigits);
                    continue;
                }
            }
        }
    }
}
