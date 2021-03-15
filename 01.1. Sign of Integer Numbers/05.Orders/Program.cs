using System;

namespace _05.Orders
{
    class Program
    {


        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = int.Parse(Console.ReadLine());
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            double sum = Price(price,quantity);
            PrintResult(sum);
            

            static void PrintResult(double sum)
            {
                Console.WriteLine($"{sum:F2}");
            }
            static double Price(double price,double quantity)
            {
                return price * quantity;
            }

        }

        
    }
}
