using System;

namespace _05.ORders
{
    class Program
    {
        static void Main(string[] args)
        {
            string line =Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double result = Sum(line, quantity);
            Print(result);
        }

        private static void Print(double result)
        {
            Console.WriteLine($"{result:F2}");
        }

        private static double Sum(string product,int count)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            return price * count;
        }
    }
}
