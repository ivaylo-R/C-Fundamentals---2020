using System;

namespace _09.TradeComision
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double capacity = double.Parse(Console.ReadLine());
            switch (city)
            {
                case "Sofia":
                    if (capacity >= 0 && capacity <= 500)
                    {
                        Console.WriteLine($"{capacity * 0.05:F2}");
                    }
                    else if (capacity > 500 && capacity <= 1000)
                    {
                        Console.WriteLine($"{capacity * 0.07:F2}");
                    }
                    else if (capacity > 1000 && capacity <= 10000)
                    {
                        Console.WriteLine($"{capacity * 0.08:F2}");
                    }
                    else if (capacity > 10000)
                    {
                        Console.WriteLine($"{capacity * 0.12:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                case "Varna":
                    if (capacity >= 0 && capacity <= 500)
                    {
                        Console.WriteLine($"{capacity * 0.045:F2}");
                    }
                    else if (capacity > 500 && capacity <= 1000)
                    {
                        Console.WriteLine($"{capacity * 0.075:F2}");
                    }
                    else if (capacity > 1000 && capacity <= 10000)
                    {
                        Console.WriteLine($"{capacity * 0.10:F2}");
                    }
                    else if (capacity > 10000)
                    {
                        Console.WriteLine($"{capacity * 0.13:F2}");

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                case "Plovdiv":
                    if (capacity >= 0 && capacity <= 500)
                    {
                        Console.WriteLine($"{capacity * 0.055:F2}");
                    }
                    else if (capacity > 500 && capacity <= 1000)
                    {
                        Console.WriteLine($"{capacity * 0.08:F2}");
                    }
                    else if (capacity > 1000 && capacity <= 10000)
                    {
                        Console.WriteLine($"{capacity * 0.12:F2}");
                    }
                    else if (capacity > 10000)
                    {
                        Console.WriteLine($"{capacity * 0.145:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
