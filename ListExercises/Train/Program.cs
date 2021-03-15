using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = "";
            bool isFitsToFirstWagon = false;
            while (command!="end")
            {
                command =Console.ReadLine();
                isFitsToFirstWagon = false;
                if (command=="end")
                {
                    Console.WriteLine(string.Join(" ", wagons));
                }
                else
                {
                    List<string> line = command.Split().ToList();
                    if (line[0]=="Add")
                    {
                        int num = int.Parse(line[1]);
                        wagons.Add(num);
                    }
                    else
                    {
                        int num = int.Parse(line[0]);
                        for (int i = 0; i < wagons.Count; i++)
                        {
                            if (isFitsToFirstWagon)
                            {
                                break;
                            }
                            int currentIndex = wagons[i];
                            for (int j = currentIndex; j < maxCapacity; j++)
                            {
                                if (currentIndex+num<=maxCapacity)
                                {
                                    currentIndex += num;
                                    wagons[i] = currentIndex;
                                    isFitsToFirstWagon = true;
                                    break;

                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
