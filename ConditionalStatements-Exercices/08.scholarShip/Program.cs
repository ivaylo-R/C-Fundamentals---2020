using System;

namespace _08.scholarShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double theMinimumOfIncome = double.Parse(Console.ReadLine());
            double socialScholarship = 0.0;
            double excellentGrade = 0.0;
            if (income < theMinimumOfIncome && averageSuccess >= 4.5)
            {
                socialScholarship = 0.35 * theMinimumOfIncome;
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if (averageSuccess >= 5.5)
            {
                excellentGrade = averageSuccess * 25;
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentGrade)} BGN");
            }
            else if (income < theMinimumOfIncome & averageSuccess >= 5.5)
            {
                socialScholarship = 0.35 * theMinimumOfIncome;
                excellentGrade = averageSuccess * 25;
                if (socialScholarship > excellentGrade)
                {
                    Console.WriteLine(Math.Floor(socialScholarship));
                }
                else if (socialScholarship == excellentGrade)
                {
                    Console.WriteLine(Math.Floor(excellentGrade));
                }
                else
                {
                    Console.WriteLine(Math.Floor(excellentGrade));
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }

    }       
}
