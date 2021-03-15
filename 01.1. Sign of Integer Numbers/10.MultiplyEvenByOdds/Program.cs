using System;
using System.Linq;

namespace _10.MultiplyEvenByOdds
{
    class Program
    {
        static void Main()
        {
            double input=Math.Abs(double.Parse(Console.ReadLine()));
            double[] allNumbers = input.ToString().ToCharArray().Select(x => Char.GetNumericValue(x)).ToArray();
            double even = 0;
            double odd = 0;
            double sumOfEven = GetSumOfEvenDigits(even ,allNumbers);
            double sumOfOdd = GetSumOfOddDigits(odd ,allNumbers);

            
            double result = GetMultipleOfEvenAndOdds(sumOfOdd,sumOfEven);
            Console.WriteLine(result);
            
        }

        private static double GetSumOfOddDigits(double odd,double [] allNumbers)
        {
            for (int i = 0; i < allNumbers.Length; i++)
            {
                if (allNumbers[i]%2==0)
                {
                     odd+= allNumbers[i];
                }
            }
            return odd;
        }

        private static double GetSumOfEvenDigits(double even, double [] allNumbers)
        {
            for (int i = 0; i < allNumbers.Length; i++)
            {
                if (allNumbers[i]%2!=0)
                {
                    even += allNumbers[i];
                }
            }
            return even;
        }

        private static double GetMultipleOfEvenAndOdds(double sumOfEven, double sumOfOdd )
        {
            return sumOfEven*sumOfOdd;
        }
    }
}
