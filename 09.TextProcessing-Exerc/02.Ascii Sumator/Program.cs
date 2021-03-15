using System;

namespace _02.Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char scnd = char.Parse(Console.ReadLine());
            string random = Console.ReadLine();
            int startIndex = 0;
            int endIndex = 0;
            int sum = 0;
            if (first > scnd)
            {
                startIndex = scnd;
                endIndex = first;
            }
            else
            {
                startIndex = first;
                endIndex = scnd;
            }

            string charsBetween = string.Empty;

            for (int i = 0; i < random.Length; i++)
            {
                int currChar = random[i];
                if (currChar > startIndex && currChar < endIndex)
                {
                    charsBetween += (char)currChar;
                }
            }

            foreach (var digit in charsBetween)
            {
                sum += digit;
            }

            Console.WriteLine($"{sum}");
        }
    }
}
