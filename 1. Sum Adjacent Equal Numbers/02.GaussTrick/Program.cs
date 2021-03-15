using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < sequence.Count-1; i++)
            {
                sequence[i] += sequence[sequence.Count- 1];
                sequence.RemoveAt(sequence.Count - 1);
                
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
