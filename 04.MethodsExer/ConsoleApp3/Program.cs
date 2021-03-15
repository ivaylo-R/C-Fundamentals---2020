using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List <int>();
            for (int i = 0; i < 3; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(CompareNums(list));

        }

        private static int CompareNums(List <int> list)
        {
            list.Sort();
            return list[0];
        }
    }
}
