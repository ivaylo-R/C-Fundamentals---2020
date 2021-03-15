using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            RepeatString(word, count);
            Console.WriteLine(word);
        }
        private static string RepeatString(string word, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += word;
            }
            
            return result;
        }
    }
}
