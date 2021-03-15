using System;

namespace Drawing_Figures_with_Loops___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}
