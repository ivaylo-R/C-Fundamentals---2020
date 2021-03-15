using System;

namespace _03_rectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double lenght = Math.Abs(x1-x2);
            double widht = Math.Abs(y1-y2);
            double area = lenght * widht;
            double Perimeter = 2*(lenght+widht);
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{Perimeter:F2}");



        }
    }
}
