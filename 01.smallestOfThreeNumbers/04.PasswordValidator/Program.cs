using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            if (!isValidLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isConsistLetterAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!HasAtleastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (HasAtleastTwoDigits(password) && isConsistLetterAndDigits(password) && isValidLenght(password))
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool isValidLenght(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
        static bool isConsistLetterAndDigits(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }
        static bool HasAtleastTwoDigits(string password)
        {
            int counter = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    counter++;
                }
            }
            return counter >= 2;
        }
    }
}
