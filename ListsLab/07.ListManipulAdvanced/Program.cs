using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = string.Empty;
            DoManipulationsAndPrintIt(list, line);
        }

        private static void DoManipulationsAndPrintIt(List<int> originalList, string command)
        {
            List<int> currentList = new List<int>(originalList);
            bool isOriginalListChanged = false;
            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    
                    if (isOriginalListChanged)
                    {
                        Console.WriteLine(string.Join(" ", currentList));
                    }
                    else
                    {
                        return;
                    }
                    
                }
                else
                {
                    List<string> manipulation = command.Split().ToList();
                    string manipulationName = manipulation[0];
                    
                    switch (manipulationName)
                    {

                        case "Add":
                            int basicsNumManipulations = int.Parse(manipulation[1]);
                            currentList.Add(basicsNumManipulations);
                            isOriginalListChanged = true;
                            break;
                        case "Remove":
                            int removeNum = int.Parse(manipulation[1]);
                            currentList.Remove(removeNum);
                            isOriginalListChanged = true;
                            break;
                        case "RemoveAt":
                            int removeIndex= int.Parse(manipulation[1]);
                            currentList.RemoveAt(removeIndex);
                            isOriginalListChanged = true;
                            break;
                        case "Insert":
                            int index = int.Parse(manipulation[2]);
                            int numOnIndex = int.Parse(manipulation[1]);
                            currentList.Insert(index, numOnIndex);
                            isOriginalListChanged = true;
                            break;
                        case "Contains":
                            int num = int.Parse(manipulation[1]);
                            if (currentList.Contains(num)) Console.WriteLine("Yes");
                            else Console.WriteLine("No such number ");
                            break;
                        case "PrintEven":
                            for (int i = 0; i < currentList.Count; i++)
                            {
                                if (currentList[i] % 2 == 0)
                                {
                                    Console.Write(currentList[i] + " ");
                                }

                            }
                            Console.WriteLine();
                            break;
                        case "PrintOdd":
                            for (int i = 0; i < currentList.Count; i++)
                            {
                                if (currentList[i] % 2 == 1)
                                {
                                    Console.Write(currentList[i] + " ");
                                }

                            }
                            Console.WriteLine();
                            break;
                        case "GetSum":
                            Console.WriteLine(currentList.Sum());
                            break;
                        case "Filter":
                            string condition = manipulation[1];
                            int number = int.Parse(manipulation[2]);
                            switch (condition)
                            {
                                case "<":
                                    for (int i = 0; i < currentList.Count; i++)
                                    {
                                        if (currentList[i] < number)
                                        {
                                            Console.Write(currentList[i] + " ");
                                        }
                                    }
                                    Console.WriteLine();
                                    break;
                                case ">":
                                    for (int i = 0; i < currentList.Count; i++)
                                    {
                                        if (currentList[i] > number)
                                        {
                                            Console.Write(currentList[i] + " ");
                                        }
                                    }
                                    Console.WriteLine();
                                    break;
                                case "<=":
                                    for (int i = 0; i < currentList.Count; i++)
                                    {
                                        if (currentList[i] <= number)
                                        {
                                            Console.Write(currentList[i] + " ");
                                        }
                                    }
                                    Console.WriteLine();
                                    break;
                                case ">=":
                                    for (int i = 0; i < currentList.Count; i++)
                                    {
                                        if (currentList[i] >= number)
                                        {
                                            Console.Write(currentList[i] + " ");
                                        }
                                    }
                                    Console.WriteLine();
                                    break;
                            }
                            break;
                    }
                }
            }
        }
    }
}
