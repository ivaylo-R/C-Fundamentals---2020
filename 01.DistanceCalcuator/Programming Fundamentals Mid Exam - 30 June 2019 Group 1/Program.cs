using System;

namespace Programming_Fundamentals_Mid_Exam___30_June_2019_Group_1
{
    class Program
    {
        static void Main()
        {
            int steps = int.Parse(Console.ReadLine());
            float stepLong = float.Parse(Console.ReadLine());
            int distaneInMetres = int.Parse(Console.ReadLine());
            int distanceInCm = distaneInMetres * 100;
            double shorterSteps = Math.Floor(steps *1.0/ 5);
            double sumOfShorterSteps = (stepLong* 0.70)*shorterSteps;
            double result = (steps-shorterSteps)*stepLong + sumOfShorterSteps;
            
            double resultInPercentage = result / distanceInCm * 100;
            Console.WriteLine($"You travelled {resultInPercentage:F2}% of the distance!");
        }
    }
}
