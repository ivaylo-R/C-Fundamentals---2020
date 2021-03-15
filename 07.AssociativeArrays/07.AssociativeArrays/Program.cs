using System;
using System.Collections.Generic;

namespace _07.AssociativeArrays
{
    class Program
    {
        static void Main()
        {
            int total = int.Parse(Console.ReadLine());
            
            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < total; i++)
            {
                var word =Console.ReadLine();
                var synonym =Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }
                words[word].Add(synonym);
            }

        }
    }
}
