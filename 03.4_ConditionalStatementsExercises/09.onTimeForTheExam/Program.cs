using System;

namespace _09.onTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int examStart = examHour * 60 + examMinutes;
            int arrive = arriveHour * 60 + arriveMinutes;
            int remain = arrive - examStart;
            int remainHours = Math.Abs(remain / 60);
            int remainMinutes = Math.Abs(remain) - remainHours*60;


            if (remain > 0)
            {
                Console.WriteLine("Late");
                if (remain < 60)
                {
                    Console.WriteLine($"{Math.Abs(remainMinutes)} minutes before the start");
                }
                else if (remain >= 60)
                {
                    Console.WriteLine($"{Math.Abs(remainHours)}:{Math.Abs(remainHours):D2} hours before the start");
                }
                
            }
            else if (remain < 60)
            {

            }







        }
    }
}
