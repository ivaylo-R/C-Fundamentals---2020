using System;

namespace _05_danceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.read input
            //L – дължина на залата в метри – реално число в интервала[10.00 … 100.00]
            double lenght = double.Parse(Console.ReadLine());
            //W – ширина на залата в метри – реално число в интервала[10.00 … 100.00]
            double widht = double.Parse(Console.ReadLine());
            //А – страна на гардероба в метри – реално число в интервала[2.00… 20.00]
            double A = double.Parse(Console.ReadLine());
            //2. hallArea in square CENTIMETERS
            double hallArea = (lenght*100)*(widht*100);
            //3. wardrobeArea
            double wardrobeArea = (A*100) * (A*100);
            //4.benchArea= hallArea/10;
            double benchArea = hallArea / 10.0;
            //6. dancerSpace = 7040 square centimeters
            double dancerSpace = 7000 + 40;
            //7. hallFreeSpace = hallAreaInCentimeters - (wardrobeArea + benchArea)
            double hallFreeSpace = hallArea - (wardrobeArea+benchArea);
            //8. dancersCount = hallFreeSpace/dancerSpace (format in Math.Round)
            double dancersCount = hallFreeSpace / dancerSpace;
            Console.WriteLine(Math.Floor(dancersCount));








        }
    }
}
