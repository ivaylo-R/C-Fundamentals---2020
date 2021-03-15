using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main()
        {
            string text1 =Console.ReadLine();
            PrintMiddleChars(CheckStringLength(text1));
        }

        private static string CheckStringLength(string text1)
        {
            if (text1.Length%2==1)
            {
                return text1[text1.Length / 2].ToString();
            }
            else
            {
                return ((text1[text1.Length/2-1]).ToString() + (text1[text1.Length / 2]).ToString()).ToString();
            }

        }

        private static void PrintMiddleChars(string p)
        {
            Console.WriteLine(p);
        }
    }
}
