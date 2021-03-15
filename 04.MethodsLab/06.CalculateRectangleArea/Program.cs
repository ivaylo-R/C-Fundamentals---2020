using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Print(CalculateRecatangleArea(a, b));
        }

        private static void Print(long v)
        {
            Console.WriteLine(v);
        }

        private static long CalculateRecatangleArea(int x,int y)
        {
            return x * y;
        }
    }
}
