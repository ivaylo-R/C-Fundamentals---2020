using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double Length = 0;
            Console.Write("Length: ");
            Length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double Height = double.Parse(Console.ReadLine());
            double V = (Length *Width * Height)/3;
            Console.Write($"Pyramid Volume: {V:f2}");
            //Length: Width: Height: Pyramid Volume: 9.00
        }
    }
}
