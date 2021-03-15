using System;

namespace _03.sumPrimeNonPrim
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            bool isPrime = true;
            int primeSum = 0;
            int nonPrimeSum = 0;

            while ((command= Console.ReadLine()) != "stop")
            {
                int currentNumber = int.Parse(command);
                isPrime = true;
                if (currentNumber<0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                for (int i = 2; i <= Math.Sqrt(currentNumber); i++)
                {
                    if(currentNumber% i == 0)
                    nonPrimeSum += currentNumber;
                    isPrime = false;
                    break;

                }
                if (isPrime)
                {
                    primeSum += currentNumber;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
