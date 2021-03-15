using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            string line = string.Empty;
            string resourse = string.Empty;
            var dict = new Dictionary<string, int>();
            var resourses = new List<string>();
            var quantity = new List<int>();
            int count = 0;
            while ((line = Console.ReadLine()) != "stop")
            {
                
                if (count % 2 == 0)
                {
                    resourses.Add(line);
                }
                else
                {
                    quantity.Add(int.Parse(line));
                }

                count++;
            }

            for (int i = 0; i < resourses.Count; i++)
            {
                if (!dict.ContainsKey(resourses[i]))
                {
                    dict[resourses[i]] = quantity[i];
                }
                else
                {
                    dict[resourses[i]] += quantity[i];
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
