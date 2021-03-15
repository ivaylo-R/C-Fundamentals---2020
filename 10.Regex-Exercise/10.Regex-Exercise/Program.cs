using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _10.Regex_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(.+)<<(\d+\.?\d*)\!(\d+)";
            string line;
            decimal totalMoneySpend = 0;
            List<string> furnitures = new List<string>();
            while ((line = Console.ReadLine()) != "Purchase")
            {
                var regex = new Regex(pattern);
                Match match = regex.Match(line);
                if (match.Success)
                {
                    string furniture = match.Groups[1].Value;
                    decimal price = decimal.Parse(match.Groups[2].Value);
                    int quan = int.Parse(match.Groups[3].Value);
                    totalMoneySpend += price * quan;
                    furnitures.Add(furniture);
                }
            }

            Console.WriteLine("Bought furniture:");
            Console.WriteLine(string.Join(Environment.NewLine,furnitures));
            Console.WriteLine($"Total money spend: {totalMoneySpend:F2}");
        }
    }
}
