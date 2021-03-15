using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");
            int health = 100;
            int currentHealth = 100;
            int tempHealth = 0;
            int bitcoins = 0;
            int roomsCount = 0;
            int currentBitCoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string command = rooms[i];
                string[] commandSplitted = command.Split();
                
                roomsCount++;
                if (commandSplitted[0] == "potion")
                {
                    tempHealth = int.Parse(commandSplitted[1]);
                    if (currentHealth<100)
                    {
                        if (health-currentHealth==tempHealth)
                        {
                            currentHealth += int.Parse(commandSplitted[1]);
                            Console.WriteLine($"You healed for {commandSplitted[1]} hp.");
                            Console.WriteLine($"Current health: {currentHealth} hp.");
                        }
                        else if (health-currentHealth<tempHealth)
                        {
                            
                            Console.WriteLine($"You healed for {health-currentHealth} hp.");
                            currentHealth += (health - currentHealth);
                            Console.WriteLine($"Current health: {currentHealth} hp.");
                        }
                        else
                        {
                            currentHealth += tempHealth;
                            Console.WriteLine($"You healed for {commandSplitted[1]} hp.");
                            Console.WriteLine($"Current health: {currentHealth} hp.");
                        }
                        
                    }

                }
                else if (commandSplitted[0] == "chest")
                {
                    currentBitCoins = 0;
                    currentBitCoins += int.Parse(commandSplitted[1]);
                    Console.WriteLine($"You found {currentBitCoins} bitcoins.");
                    bitcoins += currentBitCoins;
                }
                else
                {
                    currentHealth -= int.Parse(commandSplitted[1]);
                    if (currentHealth > 0)
                    {
                        Console.WriteLine($"You slayed {commandSplitted[0]}.");
                    }

                    if (currentHealth<=0)
                    {
                        Console.WriteLine($"You died! Killed by {commandSplitted[0]}.");
                        Console.WriteLine($"Best room: {roomsCount}");
                        return;
                    }


                }

            }
            if (health > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {currentHealth}");
            }
        }
    }
}