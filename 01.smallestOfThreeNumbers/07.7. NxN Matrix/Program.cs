using System;

namespace _07._7._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
            
        }
        static void PrintMatrix(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
            
        }
       
    }
}
