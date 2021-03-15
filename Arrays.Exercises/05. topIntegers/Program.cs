using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                for (int j = 0; j < numbers.Length; j++)
                {
                    int next = numbers[j];
                    if (current<=next)
                    {
                        break;
                    }
                    else if (j==numbers.Length-1)
                    {
                        Console.Write(numbers[i]+ " ");
                    }
                    
                }
            }
            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}