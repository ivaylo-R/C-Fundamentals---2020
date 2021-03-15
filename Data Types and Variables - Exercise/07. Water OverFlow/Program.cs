using System;

namespace _07._Water_OverFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxCapacity = 255;
            int n = int.Parse(Console.ReadLine());
            int capacity = 0;


            for (int i = 0; i < n; i++)
            {
                int littres = int.Parse(Console.ReadLine());
                
                if (maxCapacity>=capacity+littres)
                {
                    capacity += littres;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(capacity);

        }
    }
}
