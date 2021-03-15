using System;

namespace _07.areaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {

            string figures = (Console.ReadLine());
            
            if(figures == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:F3}");
            }
            else if (figures == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double area = side1 * side2;
                Console.WriteLine($"{area:F3}");
            }
            else if (figures == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine($"{area:F3}");
            }
            else if (figures == "triangle")
            {
                double length = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = (length*height)/2 ;
                Console.WriteLine($"{area:F3}");
            }          



        }
    }
}
