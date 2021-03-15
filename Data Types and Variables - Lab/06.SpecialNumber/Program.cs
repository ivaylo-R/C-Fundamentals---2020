using System;

namespace _06.SpecialNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecial = false;
            int sumOfDigits = 0;
            for (int i = 1; i <= n; i++)
            {
                
                int currentNum = i;
                sumOfDigits = 0;
                while (currentNum > 0)
                {
                    
                    sumOfDigits += currentNum%10;
                    currentNum /= 10;
                }
                if (sumOfDigits == 5 || sumOfDigits == 11 || sumOfDigits == 7)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
                isSpecial = false;
            }
        }
    }
}
