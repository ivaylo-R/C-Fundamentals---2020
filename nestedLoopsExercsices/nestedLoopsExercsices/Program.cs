﻿using System;

namespace nestedLoopsExercsices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (counter >n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(counter + " ");
                    counter++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }

        }
    }
}
