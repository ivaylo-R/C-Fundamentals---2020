using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string reversedPswd = "";
            for (int i = password.Length - 1; i >= 0; i--)
            {
                char symbol = password[i];
                reversedPswd += symbol;
            }
            
            int counter = 0;
            string tryPassword = Console.ReadLine();
            if (reversedPswd == tryPassword)
            {

                Console.WriteLine($"User {password} logged in.");
                return;
            }
            while (reversedPswd != tryPassword)
            {
                
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {password} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");

                tryPassword = Console.ReadLine();
                if (reversedPswd == tryPassword)
                {

                    Console.WriteLine($"User {password} logged in.");
                    return;
                }
            }
        }
    }
}
