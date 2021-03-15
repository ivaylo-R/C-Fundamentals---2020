using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            while (command!="end")
            {
                command =Console.ReadLine();
                if (command=="end")
                {
                    PrintResult(input);
                }
                else
                {
                    DoManipulations(input,command);
                    
                }
            }


        }

        private static List<int> DoManipulations(List<int>input,string command)
        {
            string[] arr = command.Split().ToArray();
            int num = int.Parse(arr[1]);
            string method = arr[0];
            switch (method)
            {
                case "Add":
                    input.Add(num);
                    break;
                case "Remove":
                    input.Remove(num);
                    break;
                case "RemoveAt":
                    input.RemoveAt(num);
                    break;
                case "Insert":
                    int index = int.Parse(arr[2]);
                    input.Insert(index, num);
                    break;

            }
            return input;
        }

        private static void PrintResult(List<int>input)
        {
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
