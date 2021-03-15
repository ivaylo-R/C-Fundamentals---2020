using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            double totalMoneyInsered = 0;
            double price = 0;
            double totalPriceOfProducsWanted = 0;
            bool isMoneyEnough = true;

            while (line != "Start")
            {
                double coins = double.Parse(line);
                switch (coins)
                {
                    case 0.1:
                        totalMoneyInsered += coins;
                        break;
                    case 0.2:
                        totalMoneyInsered += coins;
                        break;
                    case 0.5:
                        totalMoneyInsered += coins;
                        break;
                    case 1.0:
                        totalMoneyInsered += coins;
                        break;
                    case 2:
                        totalMoneyInsered += coins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
                line = Console.ReadLine();
            }
            line =Console.ReadLine();
            while (line != "End")
            {
                
                switch (line)
                {
                    case "Coke":
                        price = 1.0;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Nuts":
                        price = 2.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                totalPriceOfProducsWanted += price;
                if ((totalMoneyInsered - totalPriceOfProducsWanted) < 0)
                {
                    isMoneyEnough = false;
                    Console.WriteLine("Sorry, not enough money");
                    totalPriceOfProducsWanted -= price;
                }
                if ((line=="Coke"||line=="Water"||line=="Soda"||line=="Nuts"||line=="Crisps")&& isMoneyEnough)
                {
                    Console.WriteLine($"Purchased {line.ToLower()}");
                }
                line =Console.ReadLine();
            }
            double moneyLeft = totalMoneyInsered - totalPriceOfProducsWanted;
            Console.WriteLine($"Change: {moneyLeft:f2}");

        }
    }
}
