using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string messages = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();
                int currentNum = int.Parse(current);
                int lastSymbol = currentNum % 10;
                if (current.Length == 3 && lastSymbol == 2) messages += "c";
                else if (current.Length == 2 && lastSymbol == 2) messages += "b";
                else if (current.Length == 1 && lastSymbol == 2) messages += "a";
                if (current.Length == 3 && lastSymbol == 3) messages += "f";
                else if (current.Length == 2 && lastSymbol == 3) messages += "e";
                else if (current.Length == 1 && lastSymbol == 3) messages += "d";
                if (current.Length == 3 && lastSymbol == 4) messages += "i";
                else if (current.Length == 2 && lastSymbol == 4) messages += "h";
                else if (current.Length == 1 && lastSymbol == 4) messages += "g";
                if (current.Length == 3 && lastSymbol == 5) messages += "l";
                else if (current.Length == 2 && lastSymbol == 5) messages += "k";
                else if (current.Length == 1 && lastSymbol == 5) messages += "j";
                if (current.Length == 3 && lastSymbol == 6) messages += "o";
                else if (current.Length == 2 && lastSymbol == 6) messages += "n";
                else if (current.Length == 1 && lastSymbol == 6) messages += "m";
                if (current.Length == 4 && lastSymbol == 7) messages += "s";
                else if (current.Length == 3 && lastSymbol == 7) messages += "r";
                else if (current.Length == 2 && lastSymbol == 7) messages += "q";
                else if (current.Length == 1 && lastSymbol == 7) messages += "p";
                if (current.Length == 3 && lastSymbol == 8) messages += "v";
                else if (current.Length == 2 && lastSymbol == 8) messages += "u";
                else if (current.Length == 1 && lastSymbol == 8) messages += "t";
                if (current.Length == 4 && lastSymbol == 9) messages += "z";
                else if (current.Length == 3 && lastSymbol == 9) messages += "y";
                else if (current.Length == 2 && lastSymbol == 9) messages += "x";
                else if (current.Length == 1 && lastSymbol == 9) messages += "w";
                if (lastSymbol == 0)
                {
                    messages += " ";
                }
                
            }
            Console.WriteLine(messages);
        }
    }
}
