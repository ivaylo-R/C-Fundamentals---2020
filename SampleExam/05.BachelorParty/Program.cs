using System;

namespace _05.BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int singer = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double price = 0;
            double total = 0;
            int totalPeople = 0;
            int people = 0;

            while (command!= "The restaurant is full")
            {
                
                people = int.Parse(command);
                
                if (people<5 )
                {
                    
                    price = people * 100;
                }
                if (people>=5)
                {
                    price = people * 70;
                }
                total += price;
                totalPeople += people;
                command = Console.ReadLine();
            }
            double profit =Math.Abs(total - singer);
            if (profit<singer)
            {
                Console.WriteLine($"You have {totalPeople} guests and {profit} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalPeople} guests and {profit} leva income, but no singer.");
            }
        }
    }
}
