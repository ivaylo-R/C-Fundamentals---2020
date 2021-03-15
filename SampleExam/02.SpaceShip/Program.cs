using System;

namespace _02.SpaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	На първия ред е широчината на кораба - реално число в интервала[1.00... 10.00]
            double widht = double.Parse(Console.ReadLine());
            //•	На втория ред е  дължината на кораба - реално число в интервала[1.00…10.00]
            double lenght = double.Parse(Console.ReadLine());
            //•	На третия ред е височината на кораба - реално число в интервала[1.00…20.00]
            double heigh = double.Parse(Console.ReadLine());
            //•	На четвъртия ред е средната височина на астронавтите  -реално число в интервала[1.50 … 1.90]
            double heighOfAstronauts = double.Parse(Console.ReadLine());
            double capacityOfTheShip = widht * lenght * heigh;
            double capacityOfTheRoom = (heighOfAstronauts + 0.40) * 2 * 2;
            double austronauts = Math.Floor(capacityOfTheShip / capacityOfTheRoom);

            if (austronauts>=3 && austronauts<=10)
            {
                Console.WriteLine($"The spacecraft holds {austronauts} astronauts.");
            }
            else if (austronauts<3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }


        }
    }
}
