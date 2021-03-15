using System;

namespace _09.LeftAndRightsSUm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                sum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    odd += sum;
                }
                else
                {
                    even += sum;
                }    
            }
           
            if (odd == even)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + Math.Abs(odd)); 
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(odd - even));
            }

        }
    }
}
