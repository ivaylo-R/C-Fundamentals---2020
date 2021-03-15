using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        private static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintFromHundredTo1(i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintFromHundredTo1(i);
            }

        }

        private static void PrintFromHundredTo1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
