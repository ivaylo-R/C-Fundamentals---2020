using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var heroes = new Dictionary<string, Dictionary<string, int>>();
            while (n > 0)
            {
                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = tokens[0];
                int HP = int.Parse(tokens[1]);
                int MP = int.Parse(tokens[2]);
               
                heroes.Add(heroName, new Dictionary<string, int>() { ["hp"] = HP, ["mp"] = MP });
                n--;
            }
            string line;
            int maxMP = 200;
            int maxHP = 100;
            while ((line = Console.ReadLine()) != "End")
            {
                var cmd = line.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                if (cmd[0] == "CastSpell")
                {
                    string heroName = cmd[1];
                    int mpNeeded = int.Parse(cmd[2]);
                    string spellName = cmd[3];
                    if (mpNeeded <= heroes[heroName]["mp"])
                    {
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {Math.Abs(heroes[heroName]["mp"] - mpNeeded)} MP!");
                        heroes[heroName]["mp"] -= mpNeeded;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmd[0] == "TakeDamage")
                {
                    string heroName = cmd[1];
                    int damage = int.Parse(cmd[2]);
                    string attacker = cmd[3];
                    heroes[heroName]["hp"] -= damage;
                    if (heroes[heroName]["hp"] <= 0)
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName]["hp"]} HP left!");
                    }
                }
                else if (cmd[0] == "Recharge")
                {
                    string hero = cmd[1];
                    int amount = int.Parse(cmd[2]);
                    if (heroes[hero]["mp"] + amount < maxMP)
                    {
                        Console.WriteLine($"{hero} recharged for {amount} MP!");
                        heroes[hero]["mp"] += amount;
                    }
                    else
                    {
                        Console.WriteLine($"{hero} recharged for {maxMP - heroes[hero]["mp"]} MP!");
                        heroes[hero]["mp"] = maxMP;
                    }
                }
                else if (cmd[0] == "Heal")
                {
                    string hero = cmd[1];
                    int amount = int.Parse(cmd[2]);
                    if (heroes[hero]["hp"] + amount < maxHP)
                    {
                        Console.WriteLine($"{hero} healed for {amount} HP!");
                        heroes[hero]["hp"] += amount;
                    }
                    else
                    {
                        Console.WriteLine($"{hero} healed for {maxHP - heroes[hero]["hp"]} HP!");
                        heroes[hero]["hp"] = maxHP;
                    }
                }

            }

            foreach (var hero in heroes.OrderByDescending(x=>x.Value["hp"]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value["hp"]}");
                Console.WriteLine($"  MP: {hero.Value["mp"]}");
            }

        }
    }

}

