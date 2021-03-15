using System;

namespace _08.TriangleOfNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
