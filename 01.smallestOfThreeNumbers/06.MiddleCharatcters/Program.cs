using System;

namespace _06.MiddleCharatcters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            PrintMiddleCharacter(input);
            
        }
        static void PrintMiddleCharacter (string input)
        {
            if (input.Length%2==0)
            {
                char firstSymbol = input[input.Length / 2];
                char secondSymbol = input[input.Length / 2 - 1];
                Console.Write(secondSymbol + "" + firstSymbol);
            }
            else
            {
                char symbol = input[input.Length / 2];
                Console.WriteLine(symbol);
            }
        }
    }
}
