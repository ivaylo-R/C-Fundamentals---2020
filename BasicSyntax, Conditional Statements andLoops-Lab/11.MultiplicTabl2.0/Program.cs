using System;

namespace _11.MultiplicTabl2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int total = 0;
            if (multiplier>10)
            {
                total = num * multiplier;
                Console.WriteLine($"{num} X {multiplier} = {total}");
            }
            for (int i = multiplier; i <= 10; i++)
            {
                total = num * i;
                Console.WriteLine($"{num} X {i} = {total}");
                total = 0;
                
            }
        }
    }
}
