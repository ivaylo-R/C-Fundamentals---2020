using System;

namespace _04.SmallShop2
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.0;

            if (city == "Sofia")
            {
                if (product=="coffee")
                {
                    price = 0.5;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "water")
                {
                    price = 0.8;
                    Console.WriteLine(price*quantity);
                }
                else if (product == "beer")
                {
                    price = 1.2;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                    Console.WriteLine(price * quantity);
                }
                else
                {
                    price = 1.60;
                    Console.WriteLine(price * quantity);
                }
            }
            if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.40;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "water")
                {
                    price = 0.70;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "beer")
                {
                    price = 1.15;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "sweets")
                {
                    price = 1.30;
                    Console.WriteLine(price * quantity);
                }
                else
                {
                    price = 1.50;
                    Console.WriteLine(price * quantity);
                }
            }
            if (city == "Varna")
            {
                if (product == "coffee")
                    {
                        price = 0.45;
                        Console.WriteLine(price * quantity);
                }
                else if (product == "water")
                {
                        price = 0.70;
                        Console.WriteLine(price * quantity);
                }
                else if (product == "beer")
                {
                        price = 1.10;
                        Console.WriteLine(price * quantity);
                }
                else if (product == "sweets")
                {
                        price = 1.35;
                        Console.WriteLine(price * quantity);
                }
                else
                {
                        price = 1.55;
                        Console.WriteLine(price * quantity);
                }
            }

        }
    }
}
