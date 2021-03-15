using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    double sum = N1 + N2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {operation} {N2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {operation} {N2} = {sum} - odd");
                    }

                    break;
                case '-':
                    double result = N1 - N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {operation} {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {operation} {N2} = {result} - odd");
                    }

                    break;
                case '*':
                    double multiplication = N1 * N2;
                    if (multiplication % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {operation} {N2} = {multiplication} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {operation} {N2} = {multiplication} - odd");
                    }
                    break;
                case '/':
                    double Division = N1 * 1.0 / N2;
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {operation} {N2} = {Division:F2}");
                    }
                    break;
                case '%':
                    
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        int leftOver = N1 % N2;
                        Console.WriteLine($"{N1} {operation} {N2} = {leftOver}");
                    }

                    break;
            

            }




        }
    }
}
