using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double discount = 0.0;
            double evenDiscount = 0.0;
            double price = 0.0;
            double total = 0.0;
            switch (season)
            {
                case "Spring":
                 
                    price = 3000.0;
                    if (fishermen <= 6)
                    {
                        discount = price * 0.90;

                        if (fishermen % 2 == 0)
                        {
                            evenDiscount = discount * 0.95;
                            total = budget - evenDiscount;
                            Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        discount = price * 0.85;

                        if (fishermen % 2 == 0)
                        {
                            evenDiscount = discount * 0.95;
                            total = budget - evenDiscount;
                            Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                    }
                    else if (fishermen > 12)
                    {
                        discount = price * 0.75;

                        if (fishermen % 2 == 0)
                        {
                            evenDiscount = discount * 0.95;
                            total = budget - evenDiscount;
                            Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }

                        
                    }
                    break;
                case "Summer":
                    
                        price = 4200.0;
                    if (fishermen <= 6)
                    {
                        discount = price * 0.90;

                        if (fishermen % 2 == 0)
                        {
                            evenDiscount = discount * 0.95;
                            total = budget - evenDiscount;
                            if (budget >= evenDiscount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }

                        }
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        discount = price * 0.85;

                        if (fishermen % 2 == 0)
                        {
                            evenDiscount = discount * 0.95;
                            total = budget - evenDiscount;
                            if (budget >= evenDiscount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                    }
                    else if (fishermen > 12)
                    {
                        discount = price * 0.75;

                        if (fishermen % 2 == 0)
                        {
                            evenDiscount = discount * 0.95;
                            total = budget - evenDiscount;
                            if (budget >= evenDiscount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }

                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                    }
                    break;
                case "Autumn":

                    price = 4200.0;
                    if (fishermen <= 6)
                    {
                        discount = price * 0.90;
                        total = budget - discount;
                        if (budget > discount)
                        {
                            Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        discount = price * 0.85;
                        total = budget - discount;
                        if (budget > discount)
                        {
                            Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                    }
                    else if (fishermen > 12)
                    {
                        discount = price * 0.75;
                        total = budget - discount;
                        if (budget > discount)
                        {
                            Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                    }
                    break;
                case "Winter":
                    price = 2600.0;
                    if (fishermen <= 6)
                    {
                        discount = price * 0.90;

                        if (fishermen % 2 == 0)
                        {
                            evenDiscount = discount * 0.95;
                            total = budget - evenDiscount;
                            if (budget >= evenDiscount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        discount = price * 0.85;

                        if (fishermen % 2 == 0)
                        {
                            evenDiscount = discount * 0.95;
                            total = budget - evenDiscount;
                            if (budget >= evenDiscount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                    }
                    else if (fishermen > 12)
                    {
                        discount = price * 0.75;

                        if (fishermen % 2 == 0)
                        {
                            evenDiscount = discount * 0.95;
                            total = budget - evenDiscount;
                            if (budget>=evenDiscount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                        }
                        else
                        {
                            total = budget - discount;
                            if (budget >= discount)
                            {
                                Console.WriteLine($"Yes! You have {Math.Abs(total):F2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money! You need {Math.Abs(total):F2} leva.");
                            }
                            
                        }

                    }
                        break;
            }
        }
    }
}
