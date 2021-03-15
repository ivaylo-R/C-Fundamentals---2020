using System;

namespace _02.equalSumsEvenOddPossition
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            
            

            for (int i = start; i <= end; i++)
            {
                int oddSum = 0;
                int evenSum = 0;
                string numStr = i.ToString();
                for (int j = 0; j < numStr.Length; j++)
                {
                    int currentDigit = int.Parse(numStr[j].ToString());
                    if (j%2==0)
                    {
                        oddSum += currentDigit;
                    }
                    else
                    {
                        evenSum += currentDigit;
                    }
                }
                if (oddSum==evenSum)
                {
                    Console.Write(i + " ");
                }
                
            }
        }
    }
}
