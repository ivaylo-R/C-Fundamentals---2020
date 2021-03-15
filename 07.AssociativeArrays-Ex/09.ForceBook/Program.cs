using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            var forceBook = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                var line = input.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input.Contains("|"))
                {
                    
                    string side = line[0];
                    string user = line[1];

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook[side] = new List<string>();
                    }
                    if (!forceBook.Values.Any(l => l.Contains(user)))
                    {
                        forceBook[side].Add(user);
                    }

                }
                else if(input.Contains("->"))
                {
                    
                    string side = line[1];
                    string user = line[0];

                    if (forceBook.Values.Any(x=>x.Contains(user)))
                    {
                        forceBook.Values.Any(x => x.Remove(user));
                    }
                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook[side] = new List<string>();

                    }
                    forceBook[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }
            PrintResult(forceBook);
        }

        private static void PrintResult(Dictionary<string, List<string>> book)
        {
            var ordered = book.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key);
            foreach (var item in ordered)
            {
                List<string> users = item.Value.OrderBy(x => x).ToList();
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                foreach (var user in users)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
