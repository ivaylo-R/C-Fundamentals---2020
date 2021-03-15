using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int pieces = length * widht;
            
            while (command != "STOP")
            {
                int takenPieces = int.Parse(command);
                pieces -= takenPieces;

                if (pieces<=0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command=="STOP")
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }

        }
    }
}
