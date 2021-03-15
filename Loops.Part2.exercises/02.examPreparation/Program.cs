using System;

namespace _02.examPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrades = int.Parse(Console.ReadLine());
            int countPoorGrades = 0;
            double averageScore = 0;
            string command = Console.ReadLine();
            
            int sum = 0;
            string lastTask = "";   
            int countGrades = 0;
            while (command !="Enough")
            {

                int grade = int.Parse(Console.ReadLine());
                sum += grade;
                countGrades++;
                lastTask = command;
                if (grade<=4)
                {
                    countPoorGrades++;
                }
                if (countPoorGrades==maxPoorGrades)
                {
                    Console.WriteLine($"You need a break, {countPoorGrades} poor grades.");
                }
                
                command = Console.ReadLine();
                
            }
            
            
            if (command=="Enough")
            {
                averageScore = sum*1.0 /countGrades ;
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {countGrades}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

        }
    }
}
