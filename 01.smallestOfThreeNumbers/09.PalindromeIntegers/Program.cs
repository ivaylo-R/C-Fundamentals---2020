using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(isPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
                
            }
        }
        static bool isPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[0] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
