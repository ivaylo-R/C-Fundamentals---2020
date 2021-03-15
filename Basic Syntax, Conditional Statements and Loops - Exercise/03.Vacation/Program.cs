using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;
            double price = 0;
            switch (group)
            {
                case "Students":
                    if (day == "Friday") price = 8.45;
                    else if (day == "Saturday") price = 9.80;
                    else if(day=="Sunday")price=10.46;
                    break;
                case "Business":
                    if (day == "Friday") price = 10.90;
                    else if (day == "Saturday") price = 15.60;
                    else if (day == "Sunday") price = 16;
                    break;
                case "Regular":
                    if (day == "Friday") price = 15;
                    else if (day == "Saturday") price = 20;
                    else if (day == "Sunday") price = 22.50;
                    break;
            }
            totalPrice = price * people;
            if (group == "Students" && people >= 30)
            {
                totalPrice = totalPrice * 0.85;
            }
            if (group=="Business"&&people>=100)
            {
                totalPrice = (price * people) - (price * 10);
            }
            if (group=="Regular"&&(people>=10 && people<=20))
            {
                totalPrice = totalPrice * 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");

        }
    }
}
