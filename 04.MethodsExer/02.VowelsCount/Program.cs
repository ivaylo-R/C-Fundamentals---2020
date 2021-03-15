using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main()
        {
            string text =Console.ReadLine();
            Console.WriteLine(   CheckVowelsContains(text));
        }

        private static int CheckVowelsContains(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == 'O'|| text[i] == 'o'||text[i] == 'a' || text[i] == 'A' || text[i] == 'e' || text[i] == 'E' || text[i] == 'u' || text[i] == 'U' || text[i] == 'i' || text[i] == 'I')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
