using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;


            for (int h = 0; h < input.Length; h++)
            {
                int current = input[h];
                leftSum = 0;
                rightSum = 0;
                for (int i = 0; i < h; i++)
                {
                    leftSum += input[i];

                }
                for (int j = input.Length - 1; j > h; j--)
                {
                    rightSum += input[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(h);
                    return;
                }
                

            }
            Console.WriteLine("no");

        }
    }
}
