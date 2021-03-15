using System;

namespace _09.palindromeInteger
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            while (line != "END")
            {
                int num = int.Parse(line);
                Console.WriteLine(CheckIfPalindrome(num));
                line = Console.ReadLine();
            }
        }

        private static string CheckIfPalindrome(int number)
        {
            string num = number.ToString();

            if (num[0] == num[num.Length - 1])
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}