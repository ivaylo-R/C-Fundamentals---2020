using System;

namespace Mid_Exam___29_February_2020_Group_1.Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            int maxBonusPoints = 0;
            //{ total bonus} = { student attendances} / { course lectures}*(5 + { additional bonus})
            int currentAttendance = 0;
            double totalBonus = 0;
            for (int i = 0; i < students; i++)
            {

                int attendance = int.Parse(Console.ReadLine());
                totalBonus = Math.Round(attendance * 1.0 / lectures * (5 + bonus));
                if (totalBonus > maxBonusPoints)
                {
                    maxBonusPoints = (int)totalBonus;
                    currentAttendance = attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {maxBonusPoints}.");
            Console.WriteLine($"The student has attended {currentAttendance} lectures.");
        }

    }
}
