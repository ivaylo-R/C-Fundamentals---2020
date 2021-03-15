using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string line = string.Empty;
            while ((line = Console.ReadLine()) != "end")
            {
                string[] splitted = line.Split().ToArray();

                string command = splitted[0];
                if (command == "Delete")
                {
                    int numToDelete = int.Parse(splitted[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == numToDelete)
                        {
                            list.Remove(numToDelete);
                        }
                        
                    }


                }
                else if (command == "Insert")
                {
                    int numToInsert = int.Parse(splitted[1]);
                    int index = int.Parse(splitted[2]);
                    list.Insert(index, numToInsert);
                }
            }
            Print(list);
        }

        private static void Print(List<int> list)
        {
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
