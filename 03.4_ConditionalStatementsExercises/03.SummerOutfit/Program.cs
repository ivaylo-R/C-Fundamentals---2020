using System;

namespace _03.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit;
            string shoes;

            switch (time)
            {
                case "Morning":
                    if (degrees>=10 && degrees <=18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    
                    else if (degrees > 18 && degrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    
                    else
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
                case "Afternoon":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }

                    else if (degrees > 18 && degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }

                    else
                    {
                        outfit = "Swim suit";
                        shoes = "Barefoot";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
                 case "Evening":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }

                    else if (degrees > 18 && degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }

                    else
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
            
            }

            
            
        }
    }
}
