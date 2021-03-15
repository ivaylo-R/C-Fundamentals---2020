using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main()
        {
            
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="END")
                {
                    break;
                }
                else
                {
                    bool isInteger = int.TryParse(input, out int integer);
                    bool isFloatingPoint = double.TryParse(input, out double floatingPoint);
                    bool isBoolean = bool.TryParse(input, out bool boolType);
                    bool isCharacter = char.TryParse(input, out char character);
                    if (isInteger)
                    {
                        Console.WriteLine($"{input} is integer type");
                    }
                    else if (isFloatingPoint)
                    {
                        Console.WriteLine($"{input} is floating point type");
                    }
                    else if (isBoolean)
                    {
                        Console.WriteLine($"{input} is boolean type");
                    }
                    else if (isCharacter)
                    {
                        Console.WriteLine($"{input} is character type");
                    }
                    else
                    {
                        Console.WriteLine($"{input} is string type");
                    }
                }
                
                
            }
        }
    }
}
