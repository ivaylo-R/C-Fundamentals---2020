using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {

            int startingYield = int.Parse(Console.ReadLine());
            int workersConsume = 26;
            int spice = startingYield;
            int total = 0;
            int days = 0;
            if (startingYield < 100)
            {
                
                Console.WriteLine(days);
                Console.WriteLine(total);
                return;
            }
            for (int i = startingYield; i >= 100; i-=10)
            {
                
                    spice = i - workersConsume;
                    total += spice;
                    days++;
                

            }
            
            Console.WriteLine(days);
            Console.WriteLine(total-26);
            

        }
    }
}
