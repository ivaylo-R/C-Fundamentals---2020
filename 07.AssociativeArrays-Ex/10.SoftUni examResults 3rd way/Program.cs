using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUni_examResults_3rd_way
{
    class Program
    {
        static void Main()
        {
            var students = new Dictionary<string, Data>();
            string input;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] cmd = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string user = cmd[0];
                string langueage = cmd[1];
                int points = int.Parse(cmd[2]);
                
                if (input.Contains("banned"))
                {
                    if (students.ContainsKey(user))
                    {
                        students.Remove(user);
                    }
                }
                else
                {
                    if (!students.ContainsKey(user))
                    {
                        students.Add(user, new Data(new Dictionary<string, int> { { langueage, 1 } }, points));
                    }
                    else
                    {
                        if (students[user].Points < points)
                        {
                            students[user].Points = points;
                        }
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var user in students.OrderByDescending(x => x.Value.Points).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value.Points}");
            }

            Console.WriteLine("Submissions:");
            foreach (var s in students.OrderByDescending(s => s.Value.Language.Count).ThenBy(s=>s.Value.Language))
            {
                Console.WriteLine($"{s.Value.Language} - {s.Value.Language.Count}");
            }
        }
    }

    public class Data
    {
        public new Dictionary<string,int> Language { get; set; }
        public int Points { get; set; } 
        
        public Data(Dictionary<string, int> lang, int points)
        {
            this.Language = lang;
            this.Points = points;
            
        }

    }
}
