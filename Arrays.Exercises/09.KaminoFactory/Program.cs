using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int bestCount = 0;
            int bestIndex = 0;
            int bestSum = 0;
            int[] maxArr = new int[n];
            int maxCount = 0;
            int maxIndex = 0;
            int maxSample = 1;
            int currSample = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Clone them!")
                {
                    break;
                }
                int[] currArr = line
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                currSample++;
                for (int currI = 0; currI < currArr.Length; currI++)
                {
                    int currElement = currArr[currI];
                    int currCount = 1;
                    if (currElement == 0)
                    {
                        continue;
                    }
                    for (int index = currI + 1; index < currArr.Length; index++)
                    {
                        if (currArr[index] == 1)
                        {
                            currCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currCount > bestCount)
                    {
                        bestCount = currCount;
                        bestIndex = currI;
                        bestSum = currArr.Sum();

                    }

                }
                if (bestCount > maxCount || (bestCount == maxCount && maxIndex > bestIndex) || maxArr.Sum() < currArr.Sum())
                {
                    maxCount = bestCount;
                    maxArr = currArr.ToArray();
                    maxIndex = bestIndex;
                    maxSample = currSample;
                }


            }
            Console.WriteLine($"Best DNA sample {maxSample} with sum: {maxArr.Sum()}.");
            Console.WriteLine(String.Join(" ", maxArr));
        }
    }
}
