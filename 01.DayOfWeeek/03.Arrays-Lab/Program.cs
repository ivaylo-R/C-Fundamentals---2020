using System;

namespace _03.Arrays_Lab
{
    class Program
    {
        static void Main()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Satuday", "Sunday" };

            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(days[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
