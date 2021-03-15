using System;

namespace _07_AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Цена на уискито в лева – реално число в интервала [0.00 … 10000.00]
            double whiskyPrice = double.Parse(Console.ReadLine());
            //2.Количество на бирата в литри – реално число в интервала[0.00 … 1 0000.00]
            double beerInLiters = double.Parse(Console.ReadLine());
            //3.Количество на виното в литри – реално число в интервала[0.00 … 10000.00]
            double wineInLiters = double.Parse(Console.ReadLine());
            //4.Количество на ракията в литри – реално число в интервала[0.00 … 10000.00]
            double rakiaInLiters = double.Parse(Console.ReadLine());
            //5.Количество на уискито в литри – реално число в интервала[0.00 … 10000.00]
            double whiskyInLiters = double.Parse(Console.ReadLine());
            //•	цената на ракията е на половина по-ниска от тази на уискито;
            double rakiaPrice = (whiskyPrice / 2);
            //•	цената на виното е с 40 % по - ниска от цената на ракията;
            double winePrice = (rakiaPrice * (1 - 0.40));
            //•	цената на бирата е с 80 % по - ниска от цената на ракията.
            double beerPrice = (rakiaPrice*(1-0.80));
            double whiskySum = whiskyPrice * whiskyInLiters;
            double rakiaSum = rakiaInLiters * rakiaPrice;
            double wineSum = wineInLiters * winePrice;
            double beerSum = beerInLiters * beerPrice;
            double totalPrice = rakiaSum + whiskySum + beerSum + wineSum;
            Console.WriteLine($"{totalPrice:F2}");





        }
    }
}
