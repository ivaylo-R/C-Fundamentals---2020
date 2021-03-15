using System;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double destinationPrice = 0.0;
            string kindOfDestination;
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    kindOfDestination = "Camp";
                    destinationPrice = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"{kindOfDestination} - {destinationPrice:F2}");
                }
                else
                {
                    kindOfDestination = "Hotel";
                    destinationPrice = budget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"{kindOfDestination} - {destinationPrice:f2}");
                }
                    
            }
            else if (budget >100 && budget <=1000)
            {
                if (season == "summer")
                {
                    kindOfDestination = "Camp";
                    destinationPrice = budget * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"{kindOfDestination} - {destinationPrice:f2}");
                }
                else
                {
                    kindOfDestination = "Hotel";
                    destinationPrice = budget * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"{kindOfDestination} - {destinationPrice:f2}");
                }
            }
            else
            {
                kindOfDestination = "Hotel";
                destinationPrice = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"{kindOfDestination} - {destinationPrice:F2}");
            }
                


          
        }
    }
}
