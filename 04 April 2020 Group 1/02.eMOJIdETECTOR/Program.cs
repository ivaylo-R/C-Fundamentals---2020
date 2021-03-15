using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.eMOJIdETECTOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string text =Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, @"(\:\:|\*\*)(?<emojis>[A-Z][a-z]{2,})\1");
            int coolThreshH = 1;
            MatchCollection digits = Regex.Matches(text, @"\d");
            var coolEmojies = new List<string>();
            int currSymbolAsciiSum = 0;
            
            foreach (var digit in digits)
            {
                coolThreshH *= int.Parse(digit.ToString());
            }
            foreach (var match in matches)
            {
                foreach (var symbol in match.ToString())
                {
                    if (symbol!=':' && symbol!='*')
                    {
                        currSymbolAsciiSum += (int)symbol;
                    }
                    
                }
                if (currSymbolAsciiSum>coolThreshH)
                {
                    coolEmojies.Add(match.ToString());
                }
                currSymbolAsciiSum = 0;    
            }

            Console.WriteLine($"Cool threshold: {coolThreshH}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (var emoji in coolEmojies)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
