using System;

namespace _02_06_PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfOtherAnimals = int.Parse(Console.ReadLine());
            double totalSumFoodForDogs = numberOfDogs * 2.5;
            double totalSumFoodForOtherAnimals = numberOfOtherAnimals * 4.0;
            double totalFood = totalSumFoodForDogs + totalSumFoodForOtherAnimals;
            Console.WriteLine($"{totalFood:F2} lv.");

        }
    }
}
