using System;

namespace _08.hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double pricePerStudio = 0.00;
            double pricePerApartment = 0.00;

            if (month=="May" || month=="October")
            {
                pricePerStudio = 50.0*nights;
                pricePerApartment = 65.00*nights;
                if(nights>7 && nights <= 14)
                {
                    pricePerStudio = pricePerStudio * 0.95;
                }
                else if (nights >14)
                {
                    pricePerStudio = pricePerStudio * 0.70;
                    pricePerApartment = pricePerApartment* 0.90;
                }
            }
            else if (month == "June" || month =="September")
            {
                pricePerStudio = 75.20*nights;
                pricePerApartment = 68.70*nights;
                if (nights > 14)
                {
                    pricePerStudio = pricePerStudio * 0.80;
                    pricePerApartment = pricePerApartment* 0.90;
                }
                
                
            }
            else if(month=="July" || month=="August")
            {
                pricePerStudio = 76.00*nights;
                pricePerApartment = 77.00*nights;
                if (nights > 14)
                {
                    pricePerApartment = pricePerApartment * 0.90;
                 
                }
                
            }
            Console.WriteLine($"Apartment: {pricePerApartment:F2} lv.");
            Console.WriteLine($"Studio: {pricePerStudio:F2} lv.");



        }
    }
}
