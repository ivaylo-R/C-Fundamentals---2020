using System;

namespace _03.SushuTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //           •	Видът суши –  текст  –  една от възможностите: "sashimi", "maki", "uramaki", "temaki"
            string sushi = Console.ReadLine();
            //•	Име на ресторанта – текст – една от възможностите: "Sushi Zone", "Sushi Time", "Sushi Bar", "Asian Pub"
            string restaurant = Console.ReadLine();
            //•	Брой порции – цяло число в интервала[1…100]
            int porcions = int.Parse(Console.ReadLine());
            //•	Поръчка – символ – 'Y' или 'N'
            char order = char.Parse(Console.ReadLine());
            double price = 0;
            double sum = 0;
            switch (restaurant)
            {
                case "Sushi Zone":
                    if (sushi=="sashimi")
                    {
                        price = 4.99;
                    }
                    else if (sushi == "maki")
                    {
                        price = 5.29;
                    }
                    else if(sushi == "uramaki")
                    {
                        price = 5.99;
                    }
                    else
                    {
                        price = 4.29;
                    }
                    break;
                case "Sushi Time":
                    if (sushi == "sashimi")
                    {
                        price = 5.49;
                    }
                    else if (sushi == "maki")
                    {
                        price = 4.69;
                    }
                    else if (sushi == "uramaki")
                    {
                        price = 4.49;
                    }
                    else
                    {
                        price = 5.19;
                    }
                    break;
                case "Sushi Bar":
                    if (sushi == "sashimi")
                    {
                        price = 5.25;
                    }
                    else if (sushi == "maki")
                    {
                        price = 5.55;
                    }
                    else if (sushi == "uramaki")
                    {
                        price = 6.25;
                    }
                    else
                    {
                        price = 4.75;
                    }
                    break;
                case "Asian Pub":
                    if (sushi == "sashimi")
                    {
                        price = 4.50;
                    }
                    else if (sushi == "maki")
                    {
                        price = 4.80;
                    }
                    else if (sushi == "uramaki")
                    {
                        price = 5.50;
                    }
                    else
                    {
                        price = 5.50;
                    }
                    break;
                default:
                    Console.WriteLine($"{restaurant} is invalid restaurant!");
                    return;
            }

            sum = porcions * price;
            if (order=='N')
            {
                Console.WriteLine($"Total price: {Math.Round(sum+0.3)} lv.");   
            }
            if (order == 'Y')
            {
                Console.WriteLine($"Total price: {Math.Round(sum*1.2+0.3)} lv.");
            }
        }
    }
}
