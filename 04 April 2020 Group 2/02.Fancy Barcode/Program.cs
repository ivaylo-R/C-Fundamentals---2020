using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Fancy_Barcode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                Match match = Regex.Match(Console.ReadLine(), @"\@\#+[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1}\@\#+");
                if (match.Success)
                {
                    MatchCollection digits = Regex.Matches(match.Value, @"[0-9*]");
                    if (digits.Count==0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        var sb = new StringBuilder();
                        foreach (var digit in digits)
                        {
                            sb.Append(digit);
                        }
                        Console.WriteLine($"Product group: {sb}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
                n--;
            }
            
        }
    }
}
