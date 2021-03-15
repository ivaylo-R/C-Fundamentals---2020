using System;
using System.Text.RegularExpressions;

namespace _02.BossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                Match match = Regex.Match(Console.ReadLine(), @"(\|{1})(?<Boss>[A-Z]{4,})\1\:{1}\#{1}(?<Title>[A-Za-z]+\s{1}[A-Za-z]+)\#{1}");
                if (match.Success)
                {
                    int Strength = match.Groups["Boss"].Value.Length;
                    int Armour = match.Groups["Title"].Value.Length;
                    Console.WriteLine($"{match.Groups["Boss"].Value}, The {match.Groups["Title"].Value}");
                    Console.WriteLine($">> Strength: {Strength}");
                    Console.WriteLine($">> Armour: {Armour}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
                n--;
            }
        }
    }
}
