using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int marskCount = 1;
            double average = 0;

            while (marskCount<=12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade>=4.00)
                {
                    average += grade;
                    marskCount++;
                }
            }
            average /= 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            
        }
    }
}
