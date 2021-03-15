using System;
using System.Linq;

namespace _03.roundingNumbs
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var num in numbers)
            {
                double rounded = (double)Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", num , rounded);
            }
        }
    }
}
