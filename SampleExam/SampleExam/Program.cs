using System;

namespace SampleExam
{
    class Program
    {
        static void Main(string[] args)
        {


            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSouvenirs = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());
            double totalLitters = 0.07 * 420;
            double moneyForGas = totalLitters * 1.85;

            double foodAndSouvenirs = (moneyForFood * 3) + moneyForSouvenirs * 3;
            double discountForThreeDays = moneyForHotel * 0.9+ moneyForHotel * 0.85 + moneyForHotel * 0.8;
            double total = moneyForGas + foodAndSouvenirs + discountForThreeDays;
            Console.WriteLine($"Money needed: {total:F2}");
            


        }
    }
}
