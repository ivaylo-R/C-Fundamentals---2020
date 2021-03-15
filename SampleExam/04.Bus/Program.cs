using System;

namespace _04.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int passangers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 1; i <= stops; i++)
            {
                int passangerOut = int.Parse(Console.ReadLine());
                int passangerIn = int.Parse(Console.ReadLine());
                passangers -= passangerOut;
                passangers += passangerIn;
                if (i%2==1)
                {
                    passangers += 2;
                }
                else if(i%2==0)
                {
                    passangers -= 2;
                }
            }

            Console.WriteLine($"The final number of passengers is : {total}");
        }
    }
}
