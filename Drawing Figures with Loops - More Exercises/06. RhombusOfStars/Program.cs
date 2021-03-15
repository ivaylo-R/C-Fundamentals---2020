using System;

namespace _06._RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n-row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");   
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i > 0; i--)
            {
                
                for (int col = 1; col <= n - i; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col < i; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
