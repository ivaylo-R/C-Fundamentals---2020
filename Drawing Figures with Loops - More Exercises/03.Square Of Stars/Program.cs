﻿using System;

namespace _03.Square_Of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine("*");
            }
        }
    }
}
