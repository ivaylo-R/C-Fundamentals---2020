using System;

namespace _10.LowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char digit = char.Parse(Console.ReadLine());
            
            if (digit>=97 && digit<=122)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
