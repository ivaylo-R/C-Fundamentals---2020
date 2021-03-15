using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.List_Manipulation_Basics
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            ListsManipulation(input);
            Print(input);

        }

        private static void Print(List<int> output)
        {
            Console.WriteLine(String.Join(" ", output));
        }

        private static List <int> ListsManipulation(List<int> output)
        {
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] lineSplitted = line.Split().ToArray();
                string command = lineSplitted[0];
                if (command == "Add")
                {
                    int number = int.Parse(lineSplitted[1]);
                    output.Add(number);
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(lineSplitted[1]);
                    output.Remove(number);
                }

                else if (command == "RemoveAt")
                {
                    int number = int.Parse(lineSplitted[1]);
                    output.RemoveAt(number);
                }
                else if (command == "Insert")
                {
                    int num = int.Parse(lineSplitted[1]);
                    int index = int.Parse(lineSplitted[2]);
                    output.Insert(index, num);
                }
            }
            return output;
        }
    }
}
