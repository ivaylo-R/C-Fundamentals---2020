using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativeAndRevers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.RemoveAll(n => n < 0);
            if (input.Count==0)
            {
                Console.WriteLine("empty");
                return;
            }
            else
            {
                ReverseAndPrintResult(input);
            }
            

        }

        private static void ReverseAndPrintResult(List<int> input)
        {
            input.Reverse();
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
