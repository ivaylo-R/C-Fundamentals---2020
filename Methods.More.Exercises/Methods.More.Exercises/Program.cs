using System;

namespace Methods.More.Exercises
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            if (input == "int")
            {

                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(Output(integer));
            }
            else if (input == "real")
            {
                double real = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Output(real):F2}");
            }
            else
            {
                string text = Console.ReadLine();
                Console.WriteLine(Output(text));
            }
        }

        private static string Output(string input)
        {
            return $"${input}$";
        }

        private static double Output(double input)
        {
            return input * 1.5;
        }

        private static int Output(int input)
        {
            return input * 2;
        }
    }
}
