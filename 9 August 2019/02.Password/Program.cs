using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                string pass =Console.ReadLine();
                Match match = Regex.Match(pass, @"^(?<sym>.+)\>(?<first>[0-9]+)\|(?<scnd>[a-z]+)\|(?<thrd>[A-Z]+)\|(?<fourth>.+[^\<\>])\<(\k<sym>)$");
                if (!match.Success)
                {
                    Console.WriteLine($"Try another password!");
                }
                else
                {
                    var encrypted = new StringBuilder();
                    encrypted.Append(match.Groups["first"].Value);
                    encrypted.Append(match.Groups["scnd"].Value);
                    encrypted.Append(match.Groups["thrd"].Value);
                    encrypted.Append(match.Groups["fourth"].Value);

                    Console.WriteLine($"Password: {encrypted}");
                }

                n--;
            }
        }
    }
}
