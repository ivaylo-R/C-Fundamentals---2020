using System;

namespace _06.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = n % 10;
            n = n / 10;
            int second = n % 10;
            n = n / 10;

            for (int i = 1; i <= first; i++)
            {
                for (int j = 1; j <= second; j++)
                {
                    for(int k = 1; k <= n; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i*j*k};");
                    }
                }
            }
        }
    }
}
