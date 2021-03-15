using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regular_Expressions___More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tickets.Length; i++)
            {
                
                if (tickets[i].Length==20)
                {
                    var match = Regex.Match(tickets[i], @"^.*([@]{6,10}|[,]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}).*\1.*$");
                    if (match.Success)
                    {
                        int count = tickets[i].Count();
                        var leftPart = tickets[i].Substring(0, count / 2);
                        var rightPart = tickets[i].Substring(count / 2);
                        var matchesRight = Regex.Matches(rightPart,@"^.*([@]|[,]|[#]|[\^]|[$]).*$");
                        var matchesLeft = Regex.Matches(leftPart, @"^.*([@]|[,]|[#]|[\^]|[$]).*$");
                        if (matchesRight.Count==matchesLeft.Count)
                        {
                            if (matchesRight.Count>=6 && matchesRight.Count<=9)
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {matchesRight.Count}{matchesLeft[0]}");
                            }
                            else if (matchesRight.Count>=10)
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {matchesRight.Count}{matchesRight[0]} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
