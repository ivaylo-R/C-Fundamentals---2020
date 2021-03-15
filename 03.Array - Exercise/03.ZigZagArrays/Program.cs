using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            while (n != 0)
            {
                string[] splitted = Console.ReadLine().Split();
                
                if (counter % 2 == 0)
                {
                    arr1[counter] = int.Parse(splitted[0]);
                    arr2[counter] = int.Parse(splitted[1]);
                }
                else
                {
                    arr2[counter] = int.Parse(splitted[0]);
                    arr1[counter] = int.Parse(splitted[1]);
                }
                counter++;
                n--;
            }
            Console.WriteLine(string.Join(" ",arr1));
            Console.WriteLine(string.Join(" ", arr2));

        }
    }
}
