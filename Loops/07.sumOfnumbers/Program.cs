using System;

namespace _07.sumOfnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                result += number;
                
            }
            Console.WriteLine(result);
        }
    }
}
