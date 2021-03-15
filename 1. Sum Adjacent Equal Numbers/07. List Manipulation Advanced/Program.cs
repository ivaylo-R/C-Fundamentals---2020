using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isManipulationMaded = ListManipulation(input);
            if (isManipulationMaded)
            {
                PrintList(input);
            }

        }

        private static void PrintList(List <int> output)
        {
            Console.WriteLine(string.Join(" ",output));
        }

        private static bool ListManipulation(List<int> input)
        {
            string line = string.Empty;
            bool isManipulationOfListMade = false;
            while ((line = Console.ReadLine()) != "end")
            {
                string[] splitted = line.Split().ToArray();
                string command = splitted[0];
                if (command == "Add")
                {
                    int number = int.Parse(splitted[1]);
                    input.Add(number);
                    isManipulationOfListMade = true;
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(splitted[1]);
                    input.Remove(number);
                    isManipulationOfListMade = true;
                }

                else if (command == "RemoveAt")
                {
                    int number = int.Parse(splitted[1]);
                    input.RemoveAt(number);
                    isManipulationOfListMade = true;
                }
                else if (command == "Insert")
                {
                    int num = int.Parse(splitted[1]);
                    int index = int.Parse(splitted[2]);
                    input.Insert(index, num);
                    isManipulationOfListMade = true;
                }
                else if (command == "Contains")
                {
                    int n = int.Parse(splitted[1]);
                    if (input.Contains(n))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    PrintEven(input);
                }
                else if (command == "PrintOdd")
                {
                    PrintOdd(input);
                }
                else if (command == "GetSum")
                {
                    GetSum(input);
                }
                else if (command == "Filter")
                {
                    string condition = splitted[1] ;
                    int number = int.Parse(splitted[2]);
                    Filter(input, number, condition);

                }
            }
            if (!isManipulationOfListMade)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void Filter(List<int> input, int number, string condition)
        {
            if (condition == "<")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i]<number)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == ">")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] > number)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == "<=")
            {
                for (int i = 0; i <= input.Count ; i++)
                {
                    if (input[i]<=number)
                    {
                        Console.Write(input[i] + " ");
                    }
                    
                }
                Console.WriteLine();
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] >= number)
                    {
                        Console.Write(input[i] + " ");
                    }

                }
                Console.WriteLine();
            }
        }

        private static void GetSum(List<int> input)
        {
            Console.WriteLine(input.Sum());
        }

        private static void PrintOdd(List<int> input)
        {
            List<int> oddNum = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 1)
                {
                    oddNum.Add(input[i]);
                }
            }

            Console.WriteLine(String.Join(" ", oddNum));
        }

        private static void PrintEven(List<int> input)
        {
            List<int> evenNums = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    evenNums.Add(input[i]);
                }
            }

            Console.WriteLine(String.Join(" ", evenNums));
        }
    }
}
