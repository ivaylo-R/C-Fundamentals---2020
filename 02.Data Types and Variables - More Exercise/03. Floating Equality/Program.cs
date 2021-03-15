using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main()
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double diff = Math.Abs(Math.Abs(first) - Math.Abs(second));
            
            if (diff>0.0000009)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
