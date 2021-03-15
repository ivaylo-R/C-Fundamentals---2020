using System;

namespace _10.DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double meterPerSec = double.Parse(Console.ReadLine());
            double Time = distanceInMeters * meterPerSec;
            double delay = Math.Floor(distanceInMeters / 15);
            delay = delay * 12.5;
            double totalTime = (Time + delay);
            Console.WriteLine(Time);
            Console.WriteLine(delay);
            Console.WriteLine(totalTime);
        }
    }
}
