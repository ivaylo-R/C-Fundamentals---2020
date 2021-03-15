using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)(?<user>[A-Za-z]+[0-9]*[-._]?[A-Za-z0-9]*)@(?<host>[A-Za-z]+[\-]?[A-Za-z]*\.[A-Za-z]+\.?[A-Za-z]+)";
            MatchCollection emails = Regex.Matches(Console.ReadLine(), pattern);
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
