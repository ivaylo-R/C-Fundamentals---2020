using System;

namespace _03_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine()); ;
            double p = double.Parse(Console.ReadLine());
            double courses = 0;
            if (n % p == 0)
            {
                courses = n / p;
                Console.WriteLine("All the persons fit inside in the elevator.");
                Console.WriteLine("Only one course is needed.");
            }
            else
            {
                courses = Math.Ceiling((double)n / p);
                Console.WriteLine(courses);
            }
        }
    }
}
