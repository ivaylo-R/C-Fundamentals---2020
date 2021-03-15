using System;

namespace _07.TheatrePromotions
{
    class Program
    {
        static void Main()
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double price = 0;
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            if (typeOfDay == "Weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else if (age <= 64 && age > 18)
                {
                    price = 18;
                    Console.WriteLine($"{price}$");
                }
            }
            else if (typeOfDay == "Weekend")
            {
                if ((age <= 18 && age >= 0) || (age > 64 && age <= 122))
                {
                    price = 15;
                    Console.WriteLine($"{price}$");
                }
                else if (age <= 64 && age > 18)
                {
                    price = 20;
                    Console.WriteLine($"{price}$");
                }
            }
            else if (typeOfDay == "Holiday")
            {
                if (age > 64 && age <= 122)
                {
                    price = 10;
                    Console.WriteLine($"{price}$");
                }
                else if (age <= 18 && age >= 0)
                {
                    price = 5;
                    Console.WriteLine($"{price}$");
                }
                else if (age <= 64 && age > 18)
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
            }
        }
    }
}
