using System;

namespace _11.Cleverlily
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toys = 0;
            int moneyFromBirthdays = 0;
            int moneygift = 10;
            int moneyFromToys = 0;
            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday%2==0)
                {
                    moneyFromBirthdays += moneygift;
                    moneygift += 10;
                    moneyFromBirthdays -= 1;
                }
                else
                {
                    toys++;
                    
                }
            }
            moneyFromToys = toys * toyPrice;
            moneyFromBirthdays += moneyFromToys;
            double diff = Math.Abs(washingMachinePrice - moneyFromBirthdays);
            if (washingMachinePrice<=moneyFromBirthdays)
            {
                
                Console.WriteLine($"Yes! {diff:F2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:F2}");
            }

            

        }
    }
}
