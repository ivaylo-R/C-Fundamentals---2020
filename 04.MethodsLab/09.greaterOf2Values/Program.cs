using System;

namespace _09.greaterOf2Values
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type=="char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            
        }

        private static string GetMax(string a, string b)
        {

            int result = a.CompareTo(b);
            if (result > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        private static char GetMax(char a, char b)
        {

            int result = a.CompareTo(b);
            if (result > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        private static int GetMax(int a, int b)
        {

            int result = a.CompareTo(b);
            if (result > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
