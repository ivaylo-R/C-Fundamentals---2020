using System;

namespace ExerciseMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thrirdNum = int.Parse(Console.ReadLine());
            int num = SmallestNumber(firstNum, secondNum, thrirdNum);
            Console.WriteLine(num);
        }

        private static int SmallestNumber(int a, int b, int c)
        {
            int smallest = 0;
            if (a <= b && a <= c) smallest = a;
            else if (b <= a && b <= c) smallest = b;
            else smallest = c;
            return smallest;
        }
    }
}
