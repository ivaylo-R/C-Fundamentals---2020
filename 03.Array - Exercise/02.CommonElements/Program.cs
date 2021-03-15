using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 =Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            string common = string.Empty;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr2[j]==arr1[i])
                    {
                        common += arr2[j] + " ";
                    }
                }
            }
            Console.WriteLine(string.Join(" ", common));
        }
    }
}
