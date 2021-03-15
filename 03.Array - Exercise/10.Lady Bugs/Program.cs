using System;
using System.Linq;

namespace _10.Lady_Bugs
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[] startIndexes = new int[size];
            startIndexes =Console.ReadLine().Split().Select(int.Parse).ToArray();
            string line = string.Empty;

            while (line != "end")
            {
                line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }


                string [] command = line.Split().ToArray();
                int ladybugIndex =int.Parse(command[0]);
                string direction = command[1].ToString();
                int flyLength = int.Parse(command[2]);
                if (direction == "right" && (ladybugIndex + flyLength) < size)
                {
                    for (int i = ladybugIndex; i < startIndexes.Length; i++)
                    {
                        for (int j = i+flyLength; j < startIndexes.Length; j++)
                        {
                            if (startIndexes[j]==1)
                            {
                                continue;
                            }
                            else
                            {
                                startIndexes[j] = 1;
                            }
                        }

                    }


                }

            }
        }
    }
}
