using System;

namespace _04.NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int pieces = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.0;
            double total = 0.0;
            double sumLeft = 0.0;
            switch (flowers)
            {
                case "Roses":
                    price = 5.0;
                    if (pieces>80)
                    {
                        total = ((price * pieces)*0.9);
                        sumLeft = budget - total;
                        if (budget >= total)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {pieces} {flowers} and {Math.Abs(sumLeft):F2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):F2} leva more."); 
                        }
                        
                    }
                    else
                    {
                        total = price * pieces;
                        sumLeft = budget - total;
                        if (budget >= total)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {pieces} {flowers} and {Math.Abs(sumLeft):F2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):F2} leva more.");
                        }
                    }
                    break;
                case "Dahlias":
                    price = 3.80;
                    if (pieces > 90)
                    {
                        total = ((price * pieces) * 0.85);
                        sumLeft = budget - total;
                        if (budget >= total)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {pieces} {flowers} and {Math.Abs(sumLeft):F2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):F2} leva more.");
                        }

                    }
                    else
                    {
                        total = price * pieces;
                        sumLeft = budget - total;
                        if (budget >= total)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {pieces} {flowers} and {Math.Abs(sumLeft):F2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):F2} leva more.");
                        }
                    }
                    break;
                case "Tulips":
                    price = 2.80;
                    if (pieces > 80)
                    {
                        total = ((price * pieces) * 0.85);
                        sumLeft = budget - total;
                        if (budget >= total)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {pieces} {flowers} and {Math.Abs(sumLeft):F2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):F2} leva more.");
                        }

                    }
                    else
                    {
                        total = price * pieces;
                        sumLeft = budget - total;
                        if (budget >= total)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {pieces} {flowers} and {Math.Abs(sumLeft):F2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):F2} leva more.");
                        }
                    }
                    break;
                case "Narcissus":
                    price = 3.00;
                    if (pieces < 120)
                    {
                        total = ((price * pieces) * 1.15);
                        sumLeft = budget - total;
                        if (budget >= total)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {pieces} {flowers} and {Math.Abs(sumLeft):F2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):F2} leva more.");
                        }

                    }
                    else
                    {
                        total = price * pieces;
                        sumLeft = budget - total;
                        if (budget >= total)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {pieces} {flowers} and {Math.Abs(sumLeft):F2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):F2} leva more.");
                        }
                    }
                    break;
                case "Gladiolus":
                    price = 2.50;
                    if (pieces < 80)
                    {
                        total = ((price * pieces) * 1.20);
                        sumLeft = budget - total;
                        if (budget >= total)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {pieces} {flowers} and {Math.Abs(sumLeft):F2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):F2} leva more.");
                        }

                    }
                    else
                    {
                        total = price * pieces;
                        sumLeft = budget - total;
                        if (budget >= total)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {pieces} {flowers} and {Math.Abs(sumLeft):F2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):F2} leva more.");
                        }
                    }
                    break;
            }

        }
    }
}
