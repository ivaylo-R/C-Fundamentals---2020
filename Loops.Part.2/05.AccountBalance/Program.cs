using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            int counter = 1;
            double sum = 0;
            for (int i = counter; counter <= entries; counter++)
            
            {
                double payment = double.Parse(Console.ReadLine());
                if (payment >0)
                {
                    sum += payment;
                    Console.WriteLine($"Increase: {payment:f2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
            }
            Console.WriteLine($"Total: {sum:F2}");


        }
    }
}
