using System;
using System.Linq;

namespace _04.reverseArrayOfString
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
