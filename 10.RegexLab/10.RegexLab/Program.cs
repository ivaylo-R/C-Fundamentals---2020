using System;
using System.Text.RegularExpressions;

namespace _10.RegexLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var reg = new Regex(regex);
            string names =Console.ReadLine();
            MatchCollection match = Regex.Matches(names, regex);
            foreach (Match name in match)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }   
    }
}
