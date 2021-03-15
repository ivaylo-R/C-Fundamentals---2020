using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                string temp = arr[0];

                for (int i = 0; i < arr.Length-1; i++)
                {
                    string next = arr[i + 1];
                    arr[i]=next;
                }
                arr[arr.Length - 1] = temp;
                n--;
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
