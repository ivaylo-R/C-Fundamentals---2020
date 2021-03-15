using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Lists__More_ex
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var text = Console.ReadLine();
            List<char> currChar = text.ToList();
            string output = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                int sumOfDigits = 0;
                string currDigit = string.Empty;
                while (list[i] != 0)
                {
                    int curr = list[i] % 10;
                    sumOfDigits += curr;
                    list[i] /= 10;
                }

                if (sumOfDigits < text.Length)
                {
                    currDigit = currChar[sumOfDigits].ToString();
                    currChar.RemoveAt(sumOfDigits);
                }
                else
                {
                    int difference = sumOfDigits - text.Length;

                    currDigit = currChar[difference].ToString();
                    currChar.RemoveAt(difference);
                }

                output += currDigit;
            }
            PrintResult(output);
            
        }

        private static void PrintResult(string output)
        {
            Console.WriteLine(output);
        }
    }
}
