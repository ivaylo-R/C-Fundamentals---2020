using System;

namespace _05.Add_and_Substract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = Sum(num1, num2);
            int total = Substract(num3, result);
            Console.WriteLine(total);
            
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Substract(int c, int result)
        {
            return result -c;
        }
    }
}
