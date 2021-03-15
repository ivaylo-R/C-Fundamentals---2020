using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pswd = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != pswd)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
