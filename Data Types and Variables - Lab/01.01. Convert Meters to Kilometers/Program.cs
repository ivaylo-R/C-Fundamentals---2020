using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main()
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters * 0.001 ;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
