using System;

namespace _06_charityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            // read input
            //1.Броят на дните, в които тече кампанията – цяло число в интервала [0 … 365]
            int days = int.Parse(Console.ReadLine());
            //2.Броят на сладкарите – цяло число в интервала[0 … 1000]
            int confectioners = int.Parse(Console.ReadLine());
            //3.Броят на тортите – цяло число в интервала[0… 2000]
            int cakes = int.Parse(Console.ReadLine());
            //4.Броят на гофретите – цяло число в интервала[0 … 2000]
            int corrugations = int.Parse(Console.ReadLine());
            //5.Броят на палачинките – цяло число в интервала[0 … 2000]
            int pancakes = int.Parse(Console.ReadLine());
            // cakesSum = cake *45
            int cakeSum = cakes * 45;
            // corrugationsSum = corrugation*5.80
            double corrugationsSum = corrugations * 5.80;
            // pancakesSum = pancake * 3.20
            double pancakesSum = pancakes * 3.20;
            // sumPerDay = (cake+corrugation + pancakes) * numberOfConfectioners;
            double sumPerDay = (cakeSum+corrugationsSum+pancakesSum)*confectioners;
            // totalGrossSum = sumPerDay*Dayz;
            double totalGrossSum = sumPerDay * days;
            // totalNetSum = totalGrossSum - (totalGrossSum*1/8);
            double totalNetSum = totalGrossSum - (totalGrossSum*1/8);
            Console.WriteLine($"{totalNetSum:F2}");








        }
    }
}
