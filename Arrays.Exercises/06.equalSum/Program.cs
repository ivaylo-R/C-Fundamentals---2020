using System;
using System.Linq;

namespace _06.equalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumRight = 0;
            int sumLeft = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sumRight += arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sumRight -= arr[i];
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    return;
                }
                sumLeft += arr[i];
            }

            Console.WriteLine("no");

        }
    }
}
