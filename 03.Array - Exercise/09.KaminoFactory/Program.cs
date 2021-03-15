using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = string.Empty;
            
            int[] currArr = new int[n];
            int[] output = new int[currArr.Length];
            int currCount = 1;
            int bestCounter = 0;
            
            int maxCounter = 0;
            
            int maxIndex = 0;
            int maxSum = 0;
            int sample = 0;
            int maxSample = 0;
            while (line != "Clone them!")
            {

                line = Console.ReadLine();
                if (line == "Clone them!")
                {
                    break;
                }

                currArr = line.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sample++;
                currCount = 1;
                int bestIndex = 0;
                int bestSum = 0;
                for (int index = 0; index < currArr.Length; index++)
                {
                    int currElement = currArr[index];
                    if (currElement==0)
                    {
                        continue;
                    }

                    for (int i = index+1; i < currArr.Length; i++)
                    {
                        if (currArr[i]==1)
                        {
                            currCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currCount>bestCounter)
                    {
                        bestCounter = currCount;
                        bestIndex = index;
                        bestSum = currArr.Sum();
                        
                    }
                    
                }
                bestSum = currArr.Sum();
                if ((bestCounter>maxCounter)||(bestIndex<maxIndex && bestCounter==maxCounter)
                    || (bestSum> output.Sum()))
                {
                    maxIndex = bestIndex;
                    maxCounter = bestCounter;
                    maxSum = bestSum;
                    output = currArr;
                    maxSample = sample;
                }

            }
            Console.WriteLine($"Best DNA sample {maxSample} with sum: {maxSum}.");
            Console.WriteLine(String.Join(" ", output));

        }
    }
}

