using System;
using System.Linq;

namespace Problem_3._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(", ");
            string[] currArr = items.ToArray();
            while (true)
            {
                string command = Console.ReadLine();
                string[] commandSplitted = command.Split(" - ");
                
                if (command == "Craft!")
                {
                    Console.WriteLine(String.Join(", ", currArr));
                    return;
                }

                if (command == $"Collect - {commandSplitted[1]}")
                {
                    for (int i = 0; i < currArr.Length; i++)
                    {
                        
                        if (currArr[i]==commandSplitted[1])
                        {
                            
                            break;
                        }
                        else
                        {
                            currArr[currArr.Length - 1] = commandSplitted[1];
                            break;
                        }
                    }
                }
                if (command == $"Drop - {commandSplitted[1]}")
                {
                    
                    for (int i = 0; i < currArr.Length; i++)
                    {
                        if (commandSplitted[1]==currArr[i])
                        {
                            currArr[i] = items[items.Length-1];
                            break;
                        }
                    }
                }
                if (command == $"Combine items - {commandSplitted[1]}: d")
                {
                    string[] splitted = command.Split(" : ");
                    for (int i = 0; i < currArr.Length; i++)
                    {
                        if (splitted[0]==currArr[i])
                        {
                            currArr[i] = splitted[1];
                        }
                    }
                }
                if (command == $" ")
                {

                }
                
            }
        }
    }
}
