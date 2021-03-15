using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.mERGINlIST
{
    class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            PrintResult(ResultList(list1, list2));

        }

        private static void PrintResult(List<int> result)
        {
            Console.WriteLine(string.Join(" ",result));
        }

        private static List<int> ResultList(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            if (list1.Count > list2.Count)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    result.Add(list1[i]);
                    for (int j = i; j < list2.Count; j++)
                    {
                        result.Add(list2[j]);
                        break;
                    }
                }
                for (int i = list2.Count; i < list1.Count; i++)
                {
                    result.Add(list1[i]);
                }
            }
            else
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    result.Add(list1[i]);
                    for (int j = i; j < list1.Count; j++)
                    {
                        result.Add(list2[j]);
                        break;
                    }
                }
                for (int i = list1.Count; i < list2.Count; i++)
                {
                    result.Add(list2[i]);
                }
            }
            return result;
        }
    }
}
