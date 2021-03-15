using System;

namespace nestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();
            
            
            while (destination!="End")
            {
                double moneyNeeded = double.Parse(Console.ReadLine());

                double sum = 0;

                while (sum < moneyNeeded)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    sum += savedMoney;
                }

                Console.WriteLine($"Going to {destination}!");
                
                destination = Console.ReadLine();
               
            }
        }
    }
}
