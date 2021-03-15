using System;
using System.Linq;

namespace _07.maxSequenceOfEqualsElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxSequence = 0;
            int maxLeftIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int sequenceCount = 1;
                int current = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int next = arr[j];
                    if (current == next)
                    {
                        sequenceCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequenceCount > maxSequence)
                {
                    maxSequence = sequenceCount;
                    maxLeftIndex = i;
                }
            }
            string result = string.Empty;
            for (int i = 0; i < maxSequence; i++)
            {
                result += arr[maxLeftIndex] + " ";
            }
            Console.WriteLine(result);
        }
    }
}
