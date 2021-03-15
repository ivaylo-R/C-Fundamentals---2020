using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int numberOfBooks = int.Parse(Console.ReadLine());
            bool isBookFound = false;
            string nextBookName = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < numberOfBooks; i++)
            {
                if (favouriteBook==nextBookName )
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numberOfBooks} books.");
            }
        }
    }
}
