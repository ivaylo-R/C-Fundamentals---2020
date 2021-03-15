using System;
using System.Collections.Generic;

namespace _06.ReversedChar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < 3; i++)
            {
                char currentDigit = char.Parse(Console.ReadLine());
                list.Add(currentDigit);
            }
            list.Reverse();
            Console.WriteLine(String.Join(" ",list));
        }
    }
}
