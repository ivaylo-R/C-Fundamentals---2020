using System;

namespace _09.LeftAndRightsSUm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int right = 0;
            int left = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = int.Parse(Console.ReadLine());
                right += sum;

            }
            for (int i = 0; i < n; i++)
            {
                sum = int.Parse(Console.ReadLine());
                left += sum;
            }
            if (left == right)
            {
                    Console.WriteLine("Yes, sum = " + right);
                }
            else
                {
                    Console.WriteLine("No, diff = " + Math.Abs(right - left));
                }
            
        }
    }
}
