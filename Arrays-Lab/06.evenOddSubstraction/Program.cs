﻿using System;
using System.Linq;

namespace _06.evenOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int odd = 0;
            int even = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber%2==0)
                {
                    odd += currentNumber;

                }
                else
                {
                    even += currentNumber;
                }
            }
            sum = odd- even;
            Console.WriteLine(sum);
        }
    }
}
