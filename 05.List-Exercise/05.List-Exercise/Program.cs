using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.List_Exercise
{
    class Program
    {
        static void Main()
        {
            List<int> wagonsCount = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "end")
            {
                string[] splitted = line.Split().ToArray();
                if (splitted[0] == "Add")
                {
                    int passangers = int.Parse(splitted[1]);
                    wagonsCount.Add(passangers);
                }
                else if (splitted.Length==1)
                {
                    int passangers = int.Parse(splitted[0]);
                    for (int i = 0; i < wagonsCount.Count; i++)
                    {
                        if (wagonsCount[i] + passangers <= maxCapacity)
                        {
                            wagonsCount[i] += passangers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", wagonsCount));
        }
    }
}
