﻿using System;
using System.Text;

namespace _02.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    sb.Append(input[i]);
                }
                
            }
            Console.WriteLine(sb);
        }
    }
}
