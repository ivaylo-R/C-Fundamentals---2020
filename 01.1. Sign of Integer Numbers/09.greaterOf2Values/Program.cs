using System;
using System.Linq;

namespace _09.greaterOf2Values
{
    class Program
    {
        static void Main()
        {
            var typeOfOfValue = Console.ReadLine();
            var value1 = Console.ReadLine();
            var value2 = Console.ReadLine();
            var result = GetMax(typeOfOfValue, value1, value2);
            Console.WriteLine(result);
        }
        public static string GetMax(string typeOfValue, string value1, string value2)
        {
            var result1 = 0;
            var result2 = 0;
            if (typeOfValue == "int")
            {
                result1 = int.Parse(value1);
                result2 = int.Parse(value2);
            }
            else if (typeOfValue == "char")
            {
                result1 = char.Parse(value1);
                result2 = char.Parse(value2);
            }
            else if (typeOfValue == "string")
            {
                int comprasion = value1.CompareTo(value2);

            }
            if (result1 > result2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
    }
}
