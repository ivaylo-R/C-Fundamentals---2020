using System;
using System.Collections.Generic;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            MakeAndPrintMatrix(n);
        }

        private static void MakeAndPrintMatrix(int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
