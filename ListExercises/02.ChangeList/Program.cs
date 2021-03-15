using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = string.Empty;
            while (line!="end")
            {
                line =Console.ReadLine();
                if (line == "end")
                {
                    Console.WriteLine(string.Join(" ", input));
                }
                else
                {
                    List<string> lineSplit = line.Split().ToList();
                    int num = int.Parse(lineSplit[1]);
                    if (lineSplit[0]=="Delete")
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            input.Remove(num);
                        }
                    }
                    else if (lineSplit[0]=="Insert")
                    {
                        int index = int.Parse(lineSplit[1]);
                        int item = int.Parse(lineSplit[2]);
                        input.Insert(item, index);
                    }
                }
            }
        }
    }
}
