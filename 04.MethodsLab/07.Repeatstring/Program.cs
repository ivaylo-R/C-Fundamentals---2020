using System;
using System.Text;

namespace _07.Repeatstring
{
    class Program
    {
        static void Main()
        {
            string text =Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(Repeatstring(text,count));
        }

        private static string Repeatstring(string text, int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(text);
            }
            return result.ToString();
        }
    }
}
