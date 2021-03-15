using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            Print(1, 4);
            
        }

        static void Print(int start,int end)
        {
            if (start == end)
            {
                return;
            }
            Console.WriteLine(start);
            Print(start + 1, end);
            Console.WriteLine(start);

        }

        static void PrintRow(int counter)
        {
            for (int i = 1; i <= counter; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void PrintTopPart(int num)
        {
            for (int counter = 1; counter <= num; counter++)
            {
                PrintRow(counter);
            }
            
        }
        static void PrintBottomPart(int num)
        {
            for (int counter = num; counter >= 1; counter--)
            {
                PrintRow(counter);
            }
            
        }
    }
}
