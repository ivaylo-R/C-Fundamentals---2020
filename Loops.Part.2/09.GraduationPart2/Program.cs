using System;

namespace _09.GraduationPart2
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            double average = 0;
            int level = 1;
            int fails = 0;

            while (level<=12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >=4.00)
                {
                    average += grade;
                    level++;

                }
                else
                {
                    fails += 1;
                }
                if (fails> 1)
                {
                    Console.WriteLine($"{name} has been excluded at {level} grade"); break;
                }
            }

            average /= 12;
            if (fails < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }


        }
    }
}
