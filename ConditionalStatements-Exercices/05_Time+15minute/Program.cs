using System;

namespace _05_Time_15minute
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int timeInMinute = hour * 60 + minute;
            int timeInMinuteAfter15 = timeInMinute + 15;
            int hourAfter15 = timeInMinuteAfter15 / 60;
            int minuteAfter15 = timeInMinuteAfter15 % 60;
            
            if(hourAfter15 == 24)
            {
                hourAfter15 = 0;

            }

            Console.WriteLine($"{hourAfter15}:{minuteAfter15:D2}");
        }
    }
}
