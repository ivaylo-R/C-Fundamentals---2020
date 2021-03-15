using System;
using System.Collections.Generic;

namespace _03.CharacterInRange
{
    class Program
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            
            Console.WriteLine(PrintCharactersBwetween(first,second));
        }

        private static string PrintCharactersBwetween(char start, char end)
        {
            string result = string.Empty;
            if (start<end)
            {


                for (int i = start + 1; i < end; i++)
                {
                    result += (char)i + " ";
                }
            }
            else
            {
                for (int i = end+1; i < start; i++)
                {
                    result += (char)i + " ";
                }
            }
            return result;
        }
    }
}
