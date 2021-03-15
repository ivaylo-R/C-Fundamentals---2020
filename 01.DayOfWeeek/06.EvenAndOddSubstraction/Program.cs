using System;
using System.Linq;

namespace _06.EvenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            int result = 0;

            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

            Console.WriteLine($"{result=evenSum-oddSum}");
        }
    }
}
