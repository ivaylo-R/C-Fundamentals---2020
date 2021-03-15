using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i];

                bool isBigger = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    int next = array[j];
                    if (current <= next)
                    {
                        isBigger = false;
                        break;
                    }
                    
                }
                if (isBigger)
                {
                    Console.Write(current + " ");
                }
            }
        }
    }
}
