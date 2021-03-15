using System;
using System.Linq;

namespace _03.roundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var num in nums)
            {
                Console.WriteLine($"{Convert.ToDecimal(num)} => {Math.Round(Convert.ToDecimal(num),MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
