using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNum = 1;
            while (n>0)
            {
                
                if (currentNum%2==1)
                {
                    Console.WriteLine(currentNum);
                    sum += currentNum;
                }
                currentNum += 2;
                n--;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
