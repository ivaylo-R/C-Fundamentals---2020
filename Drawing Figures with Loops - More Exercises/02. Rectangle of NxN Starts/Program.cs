using System;

namespace _02._Rectangle_of_NxN_Starts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}
