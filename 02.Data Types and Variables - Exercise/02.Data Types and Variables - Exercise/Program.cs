using System;

namespace _02.Data_Types_and_Variables___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            int total = (first + second) / third * fourth;
            Console.WriteLine(total);
        }
    }
}
