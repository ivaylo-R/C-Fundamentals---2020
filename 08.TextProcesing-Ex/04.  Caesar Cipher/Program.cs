using System;
using System.Text;

namespace _04.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                int charAsNum = text[i] + 3;
                char newChar = (char)charAsNum;
                sb.Append(newChar);
            }
            Console.WriteLine(sb);
        }
    }
}
