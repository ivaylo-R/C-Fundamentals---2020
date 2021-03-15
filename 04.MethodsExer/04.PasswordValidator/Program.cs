using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main()
        {
            string pass = Console.ReadLine();
            
            bool isEnoughlength=IsCharacterLengthValid(pass);
            if (!isEnoughlength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            
            bool isConsistDigits = IsConsistDigits(pass);
            if (!isConsistDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool isHaveTwoDigits =IsHaveTwoDigits(pass);
            if (!isHaveTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isConsistDigits && isEnoughlength && isHaveTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
            
        }

        private static bool IsHaveTwoDigits(string pass)
        {
            bool isGotDigits = false;
            int count = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                char digit = pass[i];
                if (digit >= 48 && digit <= 57)
                {
                    isGotDigits = true;
                    count++;
                    if (count==2)
                    {
                        break;
                    }
                }
                else
                {
                    isGotDigits = false;
                }
            }

            return isGotDigits;
        }

        private static bool IsConsistDigits(string pass)
        {
            bool isConsistDigits = false;
            for (int i = 0; i < pass.Length; i++)
            {
                char currDigit = pass[i];
                if ((currDigit>=48 &&currDigit<=57)||(currDigit>=65 && currDigit<=90)|| (currDigit<=122 && currDigit>= 97))
                {
                    isConsistDigits = true;
                }
                else
                {
                    isConsistDigits = false;
                    break;
                    
                }
            }
            return isConsistDigits;
        }

        private static bool IsCharacterLengthValid(string pass)
        {
            if (pass.Length>=6 && pass.Length<=10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
