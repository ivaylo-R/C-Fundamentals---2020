using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativeAndreverse
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            CheckForNegative(input);
            ReverseListAndPrintResult(input);
        }

        private static void ReverseListAndPrintResult(List<int> input)
        {
            if (input.Count==0)
            {
                Console.WriteLine("empty");
                return;
            }
            input.Reverse();
            Console.WriteLine(string.Join(" ",input ));
        }

        private static List<int> CheckForNegative(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] < 0)
                {
                    input.RemoveAt(i);
                    i = 0;
                }
               
            }
            if (input[0]<0)
            {
                input.RemoveAt(0);
            }
            return input;
        }
    }
}
