using System;

namespace _09.Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalYield = 0;
            
            int workersConsume = 26;
            byte daysCounter = 0;
            while (startingYield>=100)
            {
                int currentYield = startingYield;
                currentYield -= workersConsume;
                startingYield -= 10;
                totalYield += currentYield;
                daysCounter++;
                if (startingYield<100)
                {
                    totalYield -= workersConsume;
                }
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalYield);
        }
    }
}
