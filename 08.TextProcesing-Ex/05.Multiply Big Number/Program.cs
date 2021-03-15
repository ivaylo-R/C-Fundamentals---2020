using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numAsString = Console.ReadLine();
            byte multiplier = byte.Parse(Console.ReadLine());
            int remainder = 0;
            int sum = 0;
            var output = new List<int>();
            if (multiplier==0)
            {
                Console.WriteLine(0);
                return;
            }

            while (numAsString[0]=='0')
            {
                numAsString = numAsString.Substring(1);
            }
            
            for (int i = numAsString.Length-1; i >= 0; i--)
            {
                int currentDigit = int.Parse(numAsString[i].ToString());
                sum = currentDigit * multiplier+remainder;
                int lastDigit = sum % 10;
                if (sum > 9)
                {
                    remainder = sum / 10;
                }
                else
                {
                    remainder = 0;
                }
                output.Insert(0, lastDigit);
            }
            if (remainder!=0)
            {
                output.Insert(0, remainder);
            }
            
            var sb = new StringBuilder();
            foreach (var item in output)
            {
                sb.Append(item);
            }

            Console.WriteLine(sb);
        }
    }
}
