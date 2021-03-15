using System;
using System.Linq;

namespace _05.SumOfEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOfEven = 0;

            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    sumOfEven += num;
                }
            }

            Console.WriteLine(sumOfEven);
        }
    }
}
