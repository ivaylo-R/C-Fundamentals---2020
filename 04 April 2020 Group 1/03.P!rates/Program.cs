using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string,int>>();
            string input;
            while ((input=Console.ReadLine())!="Sail")
            {
                var cmd = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string city = cmd[0];
                int population = int.Parse(cmd[1]);
                int gold = int.Parse(cmd[2]);
                if (!dict.ContainsKey(city))
                {
                    dict.Add(city, new Dictionary<string, int> { ["population"] = population, ["gold"] = gold });
                    continue;
                }
                dict[city]["population"] += population;
                dict[city]["gold"] += gold;
            }

            string text;
            while ((text = Console.ReadLine()) != "End")
            {
                var cmd = text.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = cmd[0];
                switch (action)
                {
                    case "Plunder":
                        string town = cmd[1];
                        int people = int.Parse(cmd[2]);
                        int gold = int.Parse(cmd[3]);
                        dict[town]["population"] -= people;
                        dict[town]["gold"] -= gold;
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                        if (dict[town]["population"] <= 0)
                        {
                            dict.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                            continue;
                        }
                        if (dict[town]["gold"] <= 0)
                        {
                            dict.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                            continue;
                        }
                        break;
                    case "Prosper":
                        string city = cmd[1];
                        int amountOfGold = int.Parse(cmd[2]);
                        if (amountOfGold < 0)
                        {
                            Console.WriteLine($"Gold added cannot be a negative number!");
                            continue;
                        }
                        dict[city]["gold"] += amountOfGold;
                        Console.WriteLine($"{amountOfGold} gold added to the city treasury. {city} now has {dict[city]["gold"]} gold.");
                        break;
                }

            }

            if (dict.Count!=0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {dict.Count} wealthy settlements to go to:");
                foreach (var city in dict.OrderByDescending(x => x.Value["gold"]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value["population"]} citizens, Gold: {city.Value["gold"]} kg");
                }
            }
            
        }
    }
}
