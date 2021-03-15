using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Дължина в см – цяло число в интервала[10 … 500]
            double lenght = double.Parse(Console.ReadLine());
            //2.Широчина в см – цяло число в интервала[10 … 300]
            double widght = double.Parse(Console.ReadLine());
            //3.Височина в см – цяло число в интервала[10… 200]
            double height = double.Parse(Console.ReadLine());
            //4.Процент  – реално число в интервала[0.000 … 100.000]
            double percent = double.Parse(Console.ReadLine())/100;
            // capacity paralelep. V= l*w*h in CM;
            double capacityTotal = ((lenght * widght * height)*0.001);
            double capacityWater = capacityTotal * (1 - percent);
            Console.WriteLine($"{capacityWater:F3}");




        }
    }
}
