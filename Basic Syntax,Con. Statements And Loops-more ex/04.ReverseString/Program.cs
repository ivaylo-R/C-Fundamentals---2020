using System;
using System.Collections.Generic;

namespace _04.ReverseString
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            List<char> list = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                char currentSym = word[i];
                list.Add(currentSym);
            }
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.Write(list[i]);
            }
        }
    }
}
