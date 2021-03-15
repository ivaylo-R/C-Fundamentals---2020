using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AssociativeArrays_Ex
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split().ToArray();
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    char digit = char.Parse(word[j].ToString());
                    if (dict.ContainsKey(digit))
                    {
                        dict[digit]++;
                    }
                    else
                    {
                        dict[digit] = 1;
                    }
                }
                
            }
            foreach (var digit in dict)
            {
                char key = digit.Key;
                int value = digit.Value;
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
