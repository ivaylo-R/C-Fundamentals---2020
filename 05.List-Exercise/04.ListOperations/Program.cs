using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] command = line.Split();
                string commandSplitted = command[0];
                if (commandSplitted == "Add")
                {
                    int n = int.Parse(command[1]);
                    input.Add(n);

                }
                else if (commandSplitted == "Remove")
                {
                    int n = int.Parse(command[1]);
                    if (!(n > input.Count))
                    {
                        input.RemoveAt(n);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (commandSplitted == "Insert")
                {
                    int num = int.Parse(command[1]);
                    int indexx = int.Parse(command[2]);
                    if (!(indexx > input.Count))
                    {
                        Insert(input, num, indexx);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (commandSplitted == "Shift")
                {
                    int count = int.Parse(command[2]);
                    string direction = command[1];
                    Shift(input, count, direction);
                }

            }

            PrintResult(input);
        }

        private static void PrintResult(List<int> output)
        {
            Console.WriteLine(string.Join(" ", output));
        }

        private static List<int> Shift(List<int> input, int count, string direction)
        {

            if (direction == "left")
            {
                ShiftLeft(input, count);
            }
            else if (direction == "right")
            {
                ShiftRight(input, count);
            }

            return input;
        }

        private static List<int> ShiftRight(List<int> input, int count)
        {
            while (count != 0)
            {

                for (int i = 0; i < input.Count; i++)
                {
                    int temp = input[input.Count - 1];
                    input.RemoveAt(input.Count - 1);
                    input.Insert(0, temp);
                    break;
                }
                count--;
            }

            return input;
        }

        private static List<int> ShiftLeft(List<int> input, int count)
        {
            while (count != 0)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    int temp = input[i];
                    input.RemoveAt(0);
                    input.Add(temp);
                    break;
                }
                count--;
            }
            return input;
        }

        private static List<int> Insert(List<int> input, int num, int indexx)
        {
            input.Insert(indexx, num);
            return input;
        }
    }
}
