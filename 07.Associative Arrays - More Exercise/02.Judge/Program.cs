using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            var judge = new Dictionary<string, Dictionary<string, int>>();
            var individualStatistics = new Dictionary<string, int>();
            while ((line = Console.ReadLine()) != "no more time")
            {
                var cmd = line.Split(" -> ");
                string username = cmd[0];
                string contest = cmd[1];
                int points = int.Parse(cmd[2]);
                if (!judge.ContainsKey(contest))
                {
                    judge[contest] = new Dictionary<string, int> { { username, points } };
                }

                if (judge[contest].ContainsKey(username))
                {
                    if (judge[contest][username] < points)
                    {
                        judge[contest][username] = points;
                    }
                    
                }
                else
                {
                    judge[contest].Add(username, points);
                }
                if (!individualStatistics.ContainsKey(username))
                {
                    individualStatistics[username] = points;
                }
                else
                {
                    if (individualStatistics[username]<points)
                    {
                        individualStatistics[username] = points;
                    }
                    else
                    {
                        individualStatistics[username] += points;
                    }
                    
                }

            }
            judge = judge.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            int count = 1;
            foreach (var kvp in judge)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count()} participants");
                foreach (var item in kvp.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"{count}. {item.Key} <::> {item.Value}");
                    count++;
                }
                count = 1;
            }
            Console.WriteLine("Individual standings:");
            count = 1;
            foreach (var kvp in individualStatistics.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{count}. {kvp.Key} -> {kvp.Value}");
                count++;
            }
        }
    }
}
