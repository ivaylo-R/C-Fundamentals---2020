using System;
using System.Linq;

namespace _04._arrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            string firstElement = string.Empty;
            while (n!=0)
            {
                
                firstElement = arr[0];
                for (int i = 0; i < arr.Length-1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length-1] = firstElement;
                n--;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
