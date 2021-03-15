using System;

namespace HelloCSharp
{
    class Program
    {
        static void Main()
        {
            string weather = Console.ReadLine();
            int hour = int.Parse(Console.ReadLine());

            if (hour < 21 && weather == "sunny");
            {
                Console.WriteLine("going out");
            }
            else
            {
                Console.WriteLine("not going anywehere");
            }
            }
        }
    }
}
