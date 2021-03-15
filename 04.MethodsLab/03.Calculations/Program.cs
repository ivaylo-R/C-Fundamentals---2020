using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double result = 0;
            switch (line)
            {
                case "add":
                    result= Add(x, y);
                    break;
                case "substract":
                    result = Substract(x, y);
                    break;
                case "multiply":
                    result = Multiply(x, y);
                    break;
                case "divide":
                    result = Divide(x, y);
                    break;
            }
            PrintResult(result);
        }

        private static void PrintResult(double result)
        {
            Console.WriteLine(result);
        }

        private static double Divide(int x, int y)
        {
            return x / y;
        }

        private static double Multiply(int x, int y)
        {
            return x * y;
        }

        private static double Substract(int x, int y)
        {
            return x - y;
        }

        private static double Add(int a, int b)
        {
            return a + b;
        }

        
    }
}
