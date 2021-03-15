using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main()
        {

            List<string> list = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                List<string> output = list[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < output.Count ; j++)
                {
                    Console.Write($"{output[j]} ");
                }
            }


        }
    }
}
