using System;

namespace _02.CenterPoint
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            GetClosestPoint(x1, x2, y1, y2);
        }

        private static void GetClosestPoint(double x1, double x2, double y1, double y2)
        {
            if ((x1==y1) && (y2==x2))
            {
                Console.WriteLine("({0}, {1})", x1,y1);
            }
            else
            {
                double distance1 = Math.Sqrt(x1 * x1 + x2 * x2);
                double distance2 = Math.Sqrt(y1 * y1 + y2 * y2);
                if (distance1 < distance2)
                {
                    Console.WriteLine("({0}, {1})", x1, x2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})",y1,y2);
                }
            }
        }
    }
}
