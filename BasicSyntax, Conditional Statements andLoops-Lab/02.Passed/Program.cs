﻿using System;

namespace _02.Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade>=3.0)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
