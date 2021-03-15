using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternName = @"(?<name>[A-Za-z]+)";
            string patternKm = @"(?<km>[0-9])";
            string line;
            List<string> participants = Console.ReadLine().Split(", ").ToList();
            var dict = new Dictionary<string, int>();
            string name = string.Empty;
            int km = 0;
            while ((line=Console.ReadLine()) != "end of race")
            {
                MatchCollection names = Regex.Matches(line, patternName);
                foreach (Match digit in names)
                {
                    name += digit;
                }
                if (!participants.Contains(name))
                {
                    name = string.Empty;
                    continue;
                }
                MatchCollection kilometrs = Regex.Matches(line, patternKm);
                foreach (Match digit in kilometrs)
                {
                    km += int.Parse(digit.ToString());
                }
                
                if (!dict.ContainsKey(name))
                {
                    dict[name] = km;
                }
                else
                {
                    dict[name] += km;
                }

                name = string.Empty;
                km = 0;
            }

            var bestOf3 = new List<string> ();
            dict = dict.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, b => b.Value);
            foreach (var person in dict)
            {
                bestOf3.Add(person.Key);
            }

            Console.WriteLine($"1st place: {bestOf3[0]}");
            Console.WriteLine($"2nd place: {bestOf3[1]}");
            Console.WriteLine($"3rd place: {bestOf3[2]}");
        }
    }
}
