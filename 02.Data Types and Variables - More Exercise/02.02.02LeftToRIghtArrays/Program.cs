using System;
using System.Linq;

namespace _02._02._02LeftToRIghtArrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                long digitSum = 0;
                long biggerNum = Math.Max(Convert.ToInt64(input[0]), Convert.ToInt64(input[1]));

                while (Math.Abs(biggerNum) > 0)
                {
                    digitSum += Math.Abs(biggerNum) % 10;
                    biggerNum =Math.Abs(biggerNum)/ 10;
                }
                Console.WriteLine(digitSum);

                n--;
            }

        }
    }
}
