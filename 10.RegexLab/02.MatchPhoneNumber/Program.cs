using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {


        static void Main(string[] args)
        {
            string inpt =Console.ReadLine();
            string pat = @"\+359([-]|[ ])\d{1}(\1)\d{3}(\1)\d{4}\b";
            MatchCollection matches = Regex.Matches(inpt,pat);
            var matchedPhones = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(String.Join(", ", matchedPhones));

        }
    }
}
