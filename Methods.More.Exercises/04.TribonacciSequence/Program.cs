﻿/*In the "Tribonacci" sequence, every number is formed
 by the sum of the previous 3 numbers.
 Write a program that prints num numbers from the Tribonacci
 sequence, each on a new line, starting from 1.
 The input comes as a parameter named num.
 The value num will always be positive integer.
____________________
Input         Output
4             1 1 2 4
____________________
8             1 1 2 4 7 13 24 44
___________________
*/
using System;
using System.Numerics;

namespace _0_4TribonacciSequence
{
    class Program
    {
        static void Main()
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine(0);
            }
            else if (num == 1)
            {
                Console.Write(1);
            }
            else if (num == 2)
            {
                Console.Write("1 2");
            }
            else if (num == 3)
            {
                Console.Write("1 1 2");
            }
            else
            {
                Console.Write("1 1 2 ");
                GetTribonacci(num);
            }
        }

        private static void GetTribonacci(BigInteger num)
        {
            BigInteger minus3 = 1;
            BigInteger minus2 = 1;
            BigInteger minus1 = 2;
            BigInteger max = num;
            for (int i = 0; i < max - 3; i++)
            {
                num = minus3 + minus2 + minus1;
                minus3 = minus2;
                minus2 = minus1;
                minus1 = num;
                Console.Write("{0} ", num);
            }
        }
    }
}