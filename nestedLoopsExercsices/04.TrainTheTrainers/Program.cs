using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfjury = int.Parse(Console.ReadLine());
            double grade = 0;
            string presentation = "";
            double totalGradesSum = 0;
            double sumGrades = 0;
            int counter = 0;
            while (presentation != "Finish")
            {
                presentation = Console.ReadLine();
                if (presentation == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {totalGradesSum}.");
                }
                
                
                double sumAverageScore = 0;
                
                for (int i = 1; i <= numberOfjury; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    sumGrades += grade;
                    counter++;
                }
                sumAverageScore = sumGrades / numberOfjury;
                Console.WriteLine($"{presentation} - {sumAverageScore:F2}.");
                totalGradesSum = sumAverageScore/counter;
                
            }
            
        }
    }
}
