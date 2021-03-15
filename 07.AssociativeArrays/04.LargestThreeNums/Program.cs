using System;
using System.Linq;

namespace _04.LargestThreeNums
{
    class Program
    {
        static void Main()
        {
            var sorted = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();
                
            foreach (var item in sorted)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
