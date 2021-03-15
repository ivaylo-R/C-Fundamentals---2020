using System;

namespace _07.WaterOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int waterTank = 0;
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {

                int liters = int.Parse(Console.ReadLine());
                
                if (waterTank+liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterTank += liters;
                }
            }
            
                Console.WriteLine($"{waterTank}");
        }
    }
}
