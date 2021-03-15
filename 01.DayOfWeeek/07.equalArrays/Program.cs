using System;
using System.Linq;

namespace _07.equalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = false;
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr2.Length; j++)
                {
                    if (arr1[i]==arr2[j])
                    {
                        isEqual = true;
                        sum+=arr2[j];
                        break;
                    }
                    else
                    {
                        isEqual = false;
                        Console.WriteLine($"Arrays are not identical. Found difference at {j} index");
                        return;
                    }
                }
            }
            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
