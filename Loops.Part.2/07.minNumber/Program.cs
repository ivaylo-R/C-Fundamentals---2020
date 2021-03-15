using System;

namespace _07.minNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int i = 0;
            while (i<n)
            {
                i++;
                int number = int.Parse(Console.ReadLine());
                if (number<min)
                {
                    min = number;
                }

            }
            Console.WriteLine(min);

        }
    }
}
