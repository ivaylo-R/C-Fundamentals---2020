using System;

namespace _03.CharacterInRange
{
    class Program
    {
        static void Main()
        {
            char firstDigit = char.Parse(Console.ReadLine());
            char secondDigit = char.Parse(Console.ReadLine());
            int start = 0;
            int end = 0;
            if (firstDigit > secondDigit)
            {
                start = secondDigit;
                end = firstDigit;
            }
            else
            {
                start = firstDigit;
                end = secondDigit;
            }
            PrintCharacters((char)start,(char) end);

        }
        static void PrintCharacters(char a, char b)
        {
            for (int i = a+1; i < b; i++)
            {
                
                Console.Write((char)i + " ");
            }
        }



    }
}
