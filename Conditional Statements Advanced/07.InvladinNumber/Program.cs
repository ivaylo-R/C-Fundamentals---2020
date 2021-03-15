using System;

namespace _07.InvladinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number <=200 && number >=100 || number == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
