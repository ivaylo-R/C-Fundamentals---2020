using System;

namespace _04.BackInThirtyMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes>59)
            {
                if (hours<23)
                {
                    hours += 1;
                }
                else if (hours==23)
                {
                    hours = 0;
                }
                
                minutes -= 60;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");


        }
    }
}
