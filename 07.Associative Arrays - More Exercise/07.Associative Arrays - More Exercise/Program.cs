using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Associative_Arrays___More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            var dict = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                var line = input.Split(":");
                string contest = line[0];
                string password = line[1];

                if (!dict.ContainsKey(contest))
                {
                    dict[contest] = password;
                }
            }

            string secondInput;
            var submissions = new SortedDictionary<string, SortedDictionary<string, int>>();
            while ((secondInput = Console.ReadLine()) != "end of submissions")
            {
                var data = secondInput.Split("=>");
                string contest = data[0];
                string psw = data[1];
                string username = data[2];
                int points = int.Parse(data[3]);
                if (!dict.ContainsKey(contest) || dict[contest] != psw)
                {
                    continue;
                }
                if (!submissions.ContainsKey(username))
                {
                    submissions[username] = new SortedDictionary<string, int> { { contest, points } };
                }
                if (!submissions[username].ContainsKey(contest))
                {
                    submissions[username].Add(contest, points);
                }
                if (submissions[username][contest] < points)
                {
                    submissions[username][contest] = points;
                }
            }

            var userPoints = new Dictionary<string, int>();
            foreach (var kvp in submissions)
            {
                userPoints[kvp.Key] = kvp.Value.Values.Sum();
            }
            string bestCandidate = userPoints.Keys.Max();
            int bestPoints = userPoints.Values.Max();
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");

            Console.WriteLine("Ranking:");
            foreach (var item in submissions)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(string.Join(Environment.NewLine, item.Value.OrderByDescending(x=>x.Value).Select(a=> $"#  {a.Key} -> {a.Value}")));
            }
        }
    }
}

