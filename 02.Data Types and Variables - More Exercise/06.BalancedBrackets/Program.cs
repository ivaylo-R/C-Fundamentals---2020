using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte leftBracketCounter = 0;
            byte rightBracketCounter = 0;
            for (int i = 0; i < n; i++)
            {
                string current =Console.ReadLine();
                if (current=="(")
                {
                    leftBracketCounter++;
                }
                else if (current==")")
                {
                    rightBracketCounter++;
                }
            }
            if (leftBracketCounter==rightBracketCounter)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
