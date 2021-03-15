using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }
                else
                {

                    var tokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                    string user = tokens[0];
                    string lang = tokens[1];
                    
                    if (tokens.Length > 2)
                    {
                        int points = int.Parse(tokens[2]);
                        if (!students.ContainsKey(user))
                        {
                            students.Add(user, points);
                        }
                        else
                        {
                            if (students[user] < points)
                            {
                                students[user] = points;
                            }
                        }
                        if (!submissions.ContainsKey(lang))
                        {
                            submissions.Add(lang, 0);
                        }
                        submissions[lang]++;
                    }
                    else
                    {
                        students.Remove(user);
                    }
                }
            }

            Console.WriteLine("Results:");
            foreach (var s in students.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{s.Key} | {s.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var l in submissions.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{l.Key} - {l.Value}");
            }
        }
    }
}
