using System;
using System.Linq;

namespace _10.ladyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int [] field = new int[fieldSize];

        }
    }
}
