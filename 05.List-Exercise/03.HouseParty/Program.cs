using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main()
        {
            int numOfComm = int.Parse(Console.ReadLine());
            List<string> people = new List<string>();


            Print(Guests(numOfComm, people));
        }

        private static void Print(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }

        private static List<string> Guests(int numOfComm, List<string> people)
        {
            while (numOfComm > 0)
            {

                string activity = Console.ReadLine();
                string[] splitted = activity.Split();
                string name = splitted[0];
                if (people.Contains(name) && splitted.Length == 3)
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else if (people.Contains(name) && splitted.Length == 4)
                {
                    people.Remove(name);
                }
                else if (!people.Contains(name) && splitted.Length == 4)
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
                else if (!people.Contains(name) && splitted.Length == 3)
                {
                    people.Add(name);
                }
                numOfComm--;
            }

            return people;
        }
    }
}
