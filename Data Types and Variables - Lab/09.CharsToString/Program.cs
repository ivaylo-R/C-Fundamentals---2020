using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            for (int i = 0; i <= 2; i++)
            {
                char currentDigit = char.Parse(Console.ReadLine());
                result += currentDigit;
            }
            Console.WriteLine(result);
        }
    }
}
