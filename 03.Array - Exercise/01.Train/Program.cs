using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main()
        {
            int countOfWagons = int.Parse(Console.ReadLine());
            int[] wagon = new int[countOfWagons];

            for (int i = 0; i < wagon.Length; i++)
            {
                wagon[i] =int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",wagon));
            Console.WriteLine(wagon.Sum());

        }
    }
}
