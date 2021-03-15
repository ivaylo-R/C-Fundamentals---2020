using System;

namespace _06.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //          •	Декорът за филма е на стойност 10 % от бюджета.
            //•	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.

            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double priceDress = double.Parse(Console.ReadLine());
            double totalDress = extras * priceDress;
            double decorBudget = budget * 0.1;
            if (extras > 150)
            {
                totalDress = totalDress - (totalDress * 0.1);
            }
            double totalPrice = decorBudget + totalDress;
            if (totalPrice > budget)
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
            }
            else
            {
                double theRestOfMoney = budget - totalPrice;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {theRestOfMoney:F2} leva left.");
            }

        }
    }
}
