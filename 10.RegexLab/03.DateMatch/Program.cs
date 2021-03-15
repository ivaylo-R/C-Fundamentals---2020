using System;
using System.Text.RegularExpressions;

namespace _03.DateMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine(),
                @"\b(?<day>[0-9]{2})([-.\/])(?<month>[A-Z][a-z]{2})(\2)(?<year>[0-9]{4})\b");

            foreach (Match match in matches)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["years"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
