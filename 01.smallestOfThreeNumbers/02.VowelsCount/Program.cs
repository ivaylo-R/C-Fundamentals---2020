using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int vowelsCounter = CountOfVowels(text);
            Console.WriteLine(vowelsCounter);
        }

        private static int CountOfVowels(string symbol)
        {
            int vowelsCounter = 0;
            for (int i = 0; i < symbol.Length; i++)
            {
                if (symbol[i]=='a' || symbol[i] == 'u'||symbol[i]=='o'||symbol[i]=='e' || symbol[i]=='y'|| symbol[i]=='i')
                {
                    vowelsCounter++;
                }
            }

            return vowelsCounter;
        }
    }
}
