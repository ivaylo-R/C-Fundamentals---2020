using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputPoints = int.Parse(Console.ReadLine());
            bool isWin = false;
            int counter = 0 ;
            string sector = "";
            while(sector!= "bullseye")
            {
                counter++;
                sector = Console.ReadLine();
                
                if (sector == "bullseye")
                {
                    isWin = true;
                    break;
                }
                int currentPoints = int.Parse(Console.ReadLine());
                
                if (sector== "number section")
                {
                    _=currentPoints;
                }
                else if (sector=="double ring")
                {
                    currentPoints *= 2;
                }
                else if (sector == "tripple ring")
                {
                    currentPoints *= 3;
                }

                
                inputPoints -= currentPoints;

                if (inputPoints==0)
                {
                    Console.WriteLine($"Congratulations! You won the game in {counter} moves!");
                    return;
                }
                if (inputPoints < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(inputPoints)}.");
                    return;
                }
                

            }
            if (isWin)
            {
                Console.WriteLine($"Congratulations! You won the game with a bullseye in {counter} moves!");
            }

        }
    }
}
