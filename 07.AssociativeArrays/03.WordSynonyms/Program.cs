using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main()
        {
            int total = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<string>>();
            for (int i = 0; i < total; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();
                if (!dict.ContainsKey(word))
                {
                    dict[word] = new List<string>();
                }

                dict[word].Add(synonyms);
            }
            foreach (var item in dict)
            {
                var word = item.Key;
                var synonyms = item.Value;
                Console.WriteLine($"{word} - {string.Join(", ", synonyms)}");
            }
        }
    }
}
