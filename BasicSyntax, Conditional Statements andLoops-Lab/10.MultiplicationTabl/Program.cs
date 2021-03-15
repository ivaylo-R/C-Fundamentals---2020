using System;

namespace _10.MultiplicationTabl
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = n * i;
                Console.WriteLine($"{n} X {i} = {result}");
                result = 0;
            }

        }
    }
}
