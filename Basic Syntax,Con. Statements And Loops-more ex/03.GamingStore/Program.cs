using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double spentMoney = 0;
            string line = Console.ReadLine();
            double price = 0;
            bool isOutOfMOney = false;
            bool isFound = true;

            
            while (line != "Game Time")
            {
                
                string game = line;
                switch (game)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        isFound = false;
                        break;
                }
                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");
                   
                }
                
                if (balance>=price)
                {
                    if (isFound)
                    {
                        balance -= price;
                        spentMoney += price;
                        Console.WriteLine($"Bought {game}");
                    }
                    
                }
                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    isOutOfMOney = true;
                    return;
                }
                line = Console.ReadLine();
                isFound = true;
            }
            if (line=="Game Time" && !isOutOfMOney)
            {
                Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${balance:F2}");
            }
        }
    }
}
