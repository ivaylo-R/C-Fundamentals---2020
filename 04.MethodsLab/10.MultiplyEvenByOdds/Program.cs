using System;

namespace _10.MultiplyEvenByOdds
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            
            
            double result=GetMultipleOfEvenAndOdds((CalculateDigitSum(n, 0)), (CalculateDigitSum(n, 1)));
            PrintRes(result);

        }

        private static void PrintRes(double result)
        {
            Console.WriteLine(result);
        }

        static double GetMultipleOfEvenAndOdds(int x, int y)
        {
            return y * x;
        }
        private static int CalculateDigitSum(int n, int isOdd)
        {
            string num = n.ToString();
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int currentDigit = int.Parse(num[i].ToString());
                if (currentDigit%2==isOdd)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
    }
}
