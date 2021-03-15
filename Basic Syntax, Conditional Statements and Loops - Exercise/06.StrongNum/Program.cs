using System;

namespace _06.StrongNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = input;
            int currentSymbol = 0;
            int factorial = 0;
            int sumOfFactorials = 0;

            while (num != 0)
            {
                currentSymbol = num % 10;


                factorial = currentSymbol;
                for (int j = 1; j < currentSymbol; j++)
                {
                    factorial *= j;
                }

                sumOfFactorials += factorial;
                if (currentSymbol == 0)
                {
                    sumOfFactorials += 1;

                }
                num /= 10;
            }


            if (sumOfFactorials == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
