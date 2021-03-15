using System;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main()
        {
            var fruits = Console.ReadLine()
                .Split()
                .ToArray()
                .Where(x => x.Length % 2 == 0);

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
                
           
        }
    }
}
