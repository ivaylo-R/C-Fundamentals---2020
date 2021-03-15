using System;

namespace Arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfweek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if (day>=1 && day<=7)
            {
                Console.WriteLine(dayOfweek[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
                        
        }
    }
}
