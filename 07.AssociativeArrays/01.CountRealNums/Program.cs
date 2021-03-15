using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNums
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            var counts = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                int result = !counts.ContainsKey(number)
                 ? counts[number] = 1
                 : counts[number]++;
            }
            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
