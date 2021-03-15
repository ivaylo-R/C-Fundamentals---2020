using System;

namespace _02.cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double seats = rows * columns;
            double income = 0.0;
            switch (projection)
            {
                case "Premiere":
                    income = seats * 12.00;
                    Console.WriteLine($"{income:f2} leva");
                    break;
                case "Normal":
                    income = seats * 7.50;
                    Console.WriteLine($"{income:f2} leva");
                    break;
                case "Discount":
                    income = seats * 5.0;
                    Console.WriteLine($"{income:f2} leva");
                    break;
            }




        }
    }
}
