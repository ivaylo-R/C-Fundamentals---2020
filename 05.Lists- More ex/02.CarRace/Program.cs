using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            double left = LeftRacer(input);
            double right = RightRacer(input);
            
            PrintResult(left, right);
        }

        private static void PrintResult(double left, double right)
        {
            if (left<=right)
            {
                Console.WriteLine($"The winner is left with total time: {left}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {right}");
            }

        }


        private static double RightRacer(List<int> input)
        {
            double summ = 0;
            for (int i = input.Count - 1; i > input.Count / 2; i--)
            {
                summ += input[i];
                if (input[i] == 0)
                {
                    summ *= 0.8;
                }
            }
            
            return summ;
        }

        private static double LeftRacer(List<int> input)
        {
            double sum = 0;

            for (int i = 0; i < input.Count / 2; i++)
            {
                sum += input[i];
                if (input[i]==0)
                {
                    sum *= 0.8;
                }
            }
            
            return sum;
        }
    }
}
