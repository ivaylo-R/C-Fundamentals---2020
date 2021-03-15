using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().ToLower().Split().ToList();
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                var result = !counts.ContainsKey(word)
                    ? counts[word] = 1
                    : counts[word]++;
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 == 1)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
