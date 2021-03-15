using System;
using System.Linq;


namespace _04._reverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split();
            for (int i = values.Length - 1; i >= 0; i--)
            {
                Console.Write(values[i] + " ");
            }
        }
    }
}
