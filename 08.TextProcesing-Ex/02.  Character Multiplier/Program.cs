using System;

namespace _02.__Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            string text1 = input[0];
            string text2 = input[1];
          
            int totalSum = 0;
            if (text1.Length > text2.Length)
            {
                for (int i = 0; i < text2.Length; i++)
                {
                    totalSum += text1[i] * text2[i];
                }
                for (int i = text2.Length; i < text1.Length; i++)
                {
                    totalSum += text1[i];
                }
            }
            else if (text2.Length==text1.Length)
            {
                for (int i = 0; i < text1.Length; i++)
                {
                    totalSum += text1[i] * text2[i];
                }
            }
            else
            {
                for (int i = 0; i < text1.Length; i++)
                {
                    totalSum += text1[i] * text2[i];
                }
                for (int i = text1.Length; i < text2.Length; i++)
                {
                    totalSum += text2[i];
                }
            }
            Console.WriteLine($"{totalSum}");
        }
    }
}
