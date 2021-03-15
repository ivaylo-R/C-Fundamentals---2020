using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            var heroes = new Dictionary<string, List<string>>();
            while ((line = Console.ReadLine()) != "End")
            {
                string[] cmd = line.Split();
                if (cmd[0] == "Enroll")
                {
                    string heroName = cmd[1];
                    if (!heroes.ContainsKey(heroName))
                    {
                        heroes.Add(heroName, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                else if (cmd[0] == "Learn")
                {
                    string hero = cmd[1];
                    string spell = cmd[2];
                    if (!heroes.ContainsKey(hero))
                    {
                        Console.WriteLine($"{hero} doesn't exist.");
                        continue;
                    }
                    if (heroes.ContainsKey(hero) && !heroes[hero].Contains(spell))
                    {
                        heroes[hero].Add(spell);
                        continue;
                    }
                    else if (heroes[hero].Contains(spell))
                    {
                        Console.WriteLine($"{hero} has already learnt {spell}.");
                    }
                   
                }
                else if (cmd[0] == "Unlearn")
                {
                    string hero = cmd[1];
                    string spell = cmd[2];
                    if (!heroes.ContainsKey(hero))
                    {
                        Console.WriteLine($"{hero} doesn't exist.");
                        continue;
                    }
                    if (heroes[hero].Contains(spell))
                    {
                        heroes[hero].Remove(spell);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{hero} doesn't know {spell}.");
                    }
                }
            }

            Console.WriteLine($"Heroes:");
            foreach (var hero in heroes.OrderByDescending(y=>y.Value.Count()).ThenBy(y=>y.Key))
            {
                Console.Write($"== {hero.Key}: ");
                foreach (var item in hero.Value)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
    }
}
