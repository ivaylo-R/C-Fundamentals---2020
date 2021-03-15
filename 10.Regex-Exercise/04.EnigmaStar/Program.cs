using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.EnigmaStar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var decrypted = string.Empty;
            var attackedPlanets = new List<string>();
            var destroyedPl = new List<string>();

            while (n!=0)
            {
                string msg = Console.ReadLine();
                MatchCollection matches = Regex.Matches(msg, @"[sS,tT,aA,rR]");
                int key = matches.Count;
                for (int i = 0; i < msg.Length; i++)
                {
                    char current = (char)msg[i];
                    current -= (char)key;
                    decrypted += current;
                }
                Match dectryptedMatch = Regex.Match(decrypted, @"^[^@\-!:>]*\@(?<planet>[A-Za-z]+)[^@\-!:>]*\:[^@\-!:>]*(?<population>\d+)[^@\-!:>]*\![^@\-!:>]*(?<attackType>[AD])[^@\-!:>]*\![^@\-!:>]*\-\>(?<soldiers>\d+)[^@\-!:>]*$");
                if (dectryptedMatch.Success)
                {
                    if (dectryptedMatch.Groups["attackType"].Value=="A")
                    {
                        attackedPlanets.Add(dectryptedMatch.Groups["planet"].Value);
                    }
                    else if (dectryptedMatch.Groups["attackType"].Value == "D")
                    {
                        destroyedPl.Add(dectryptedMatch.Groups["planet"].Value);
                    }
                }
                decrypted = string.Empty;
                n--;
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count != 0)
            {
                foreach (var planet in attackedPlanets.OrderBy(x=>x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyedPl.Count}");
            
            if (destroyedPl.Count!=0)
            {

                foreach (var planet in destroyedPl.OrderBy(x=>x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
