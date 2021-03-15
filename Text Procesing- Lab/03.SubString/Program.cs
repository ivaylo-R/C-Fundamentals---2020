using System;

namespace _03.SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine().ToLower();
            string text = Console.ReadLine();
            while (true)
            {
                int startIndex = text.IndexOf(key);
                if (startIndex==-1)
                {
                    break;
                }
                text = text.Remove(startIndex, key.Length);
            }
            Console.WriteLine(text);
        }
    }
}
