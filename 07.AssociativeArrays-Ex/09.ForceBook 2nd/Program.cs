using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook_2nd
{
    class Program
    {
        static void Main()
        {
            var sides = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                var tokens = input.Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries);
                if (input.Contains("|"))
                {
                    string side = tokens[0];
                    string user = tokens[1];
                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new List<string> ());

                    }
                    if (!sides.Values.Any(x=>x.Contains(user)))
                    {
                        sides[side].Add(user);
                    }
                }
                else if (input.Contains("->"))
                {
                    string side = tokens[1];
                    string user = tokens[0];
                    if (sides.ContainsKey(side))
                    {

                        if (!sides[side].Contains(user))
                        {
                            if (sides.Values.Any(x => x.Contains(user)))
                            {
                                sides.Values.Any(x => x.Remove(user));
                            }

                        }
                        if(!sides.ContainsKey(side))
                        {
                            sides.Add(side, new List<string>());
                        }
                        sides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }

            var ordered = sides.Where(x => x.Value.Count != 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);
            foreach (var side in ordered)
            {
                var usersOrdered = side.Value.OrderBy(x => x).ToList();
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in usersOrdered)
                {
                    Console.WriteLine($"! {user}");
                }


            }
        }
    }


}
