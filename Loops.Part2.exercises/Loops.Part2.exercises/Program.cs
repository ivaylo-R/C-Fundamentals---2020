using System;

namespace Loops.Part2.exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int counter = 0;

            double changeInSt = Math.Floor(change* 100);

            while (changeInSt > 0)
            {
                if (changeInSt>=200)
                {
                    changeInSt -= 200;
                    counter++;
                }
                else if (changeInSt >= 100)
                {
                    changeInSt -= 100;
                    counter++;
                }
                else if (changeInSt >= 50)
                {
                    changeInSt -= 50;
                    counter++;
                }
                else if (changeInSt >= 20)
                {
                    changeInSt -= 20;
                    counter++;
                }
                else if (changeInSt >= 10)
                {
                    changeInSt -= 10;
                    counter++;
                }
                else if (changeInSt >= 5)
                {
                    changeInSt -= 5;
                    counter++;
                }
                else if (changeInSt >= 2)
                {
                    changeInSt -= 2;
                    counter++;
                }
                else if (changeInSt >= 1)
                {
                    changeInSt -= 1;
                    counter++;
                }
            }


            Console.WriteLine(counter);
        }
    }
}
