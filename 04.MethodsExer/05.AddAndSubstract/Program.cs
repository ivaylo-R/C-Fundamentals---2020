using System;

namespace _05.AddAndSubstract
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine((AddAndSubstract(Sum(first, second),third)));
        }

        private static int AddAndSubstract(int v, int third)
        {
            return v - third;
        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}
