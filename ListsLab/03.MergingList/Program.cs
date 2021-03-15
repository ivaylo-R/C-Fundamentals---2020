using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingList
{
    class Program
    {
        static void Main()
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < Math.Min(first.Count,second.Count); i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }
            if (first.Count>second.Count)
            {
                result.AddRange(GetRangeLast(first,second));
            }
            else if (second.Count>first.Count)
            {
                result.AddRange(GetRangeLast(second, first));
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static List <int> GetRangeLast(List<int> longer, List <int> shorter)
        {
            List<int> list = new List<int>();
            for (int i = shorter.Count; i < longer.Count; i++)
            {
                list.Add(longer[i]);
            }
            return list;
        }
    }
}
