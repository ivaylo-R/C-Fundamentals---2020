using System;

namespace _08.toyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfTrip = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double total = puzzle * 2.60 + dolls * 3.0 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;
            int numberOfToys = puzzle + dolls + teddyBears + minions + trucks;
            if (numberOfToys>=50)
            {
                 total = total-total * 0.25;
            }
            total = total - total * 0.10;
            if (total>= priceOfTrip)
            {
                Console.WriteLine($"Yes! {total-priceOfTrip:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceOfTrip- total:F2} lv needed.");
            }




        }
    }
}
