using System;

namespace _07_WordSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters= double.Parse(Console.ReadLine());
            double meterPerSec = double.Parse(Console.ReadLine());
            double Time = distanceInMeters * meterPerSec;
            double delay = Math.Floor(distanceInMeters / 15);
            delay = delay * 12.5;
            double totalTime = (Time + delay);
            
            if (record > totalTime)
            {

                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                totalTime = totalTime - record;
                Console.WriteLine($"No, he failed! He was {totalTime:F2} seconds slower.");
            }
        }
    }
}
