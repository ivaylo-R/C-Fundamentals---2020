using System;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. read input
            //•	Брой правоъгълни маси – цяло число в интервала [0...500]
            int table = int.Parse(Console.ReadLine());
            //•	Дължина на правоъгълните маси в метри – реално число в интервала[0.00...3.00]
            double length = double.Parse(Console.ReadLine());
            //•	Широчина на правоъгълните маси в метри – реално число в интервала[0.00...3.00]
            double widht = double.Parse(Console.ReadLine());
            // area tablecloth = lenght * widht
            double areaTableCloth = table*(length+2*0.3)*(widht+2*0.3);
            // area coach = lenght*0,5*widht/2
            double areaCoach = table * ((length / 2) * (length/2));
            // dollarPrice = (tablecloth*7) + (coach*9)
            double dollarPrice = (areaTableCloth * 7) + (areaCoach*9);
            // levaPrice = dollarPrice*1,85
            double levaPrice = dollarPrice * 1.85;
            // print usd format to second symbol
            Console.WriteLine($"{dollarPrice:F2} USD");
            // print leva format to second symbl
            Console.WriteLine($"{levaPrice:F2} BGN");








        }
    }
}
