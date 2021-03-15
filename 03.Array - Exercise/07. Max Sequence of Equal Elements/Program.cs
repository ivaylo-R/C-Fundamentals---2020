using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxLength = 0;
            int counter = 1;

            int start = 0;
            int bestStart = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                    start = i + 1;
                }
                if (counter > maxLength)
                {
                    maxLength = counter;
                    bestStart = start;
                }
            }

            for (int j = bestStart; j < bestStart + maxLength; j++)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}
