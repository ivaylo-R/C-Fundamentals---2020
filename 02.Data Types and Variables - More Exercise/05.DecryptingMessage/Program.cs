using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main()
        {
            byte key = byte.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            string output = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char current = char.Parse(Console.ReadLine());
                int currentPlusKey= current+ key;
                output += (char)currentPlusKey;
            }
            Console.WriteLine(output);
        }
    }
}
