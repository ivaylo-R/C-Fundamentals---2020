using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<quan>[0-9]+)\|[^|$%.]*?(?<price>[0-9]+\.?[0-9]*)\$";
            string line;
            double result = 0;
            while ((line = Console.ReadLine()) != "end of shift")
            {
                Match customers = Regex.Match(line, pattern);
                
                if (customers.Success)
                {
                    string customer = customers.Groups["name"].Value;
                    string product =customers.Groups["product"].Value;
                    int quantity = int.Parse(customers.Groups["quan"].Value);
                    double price = double.Parse(customers.Groups["price"].Value);
                    double total = quantity * price;
                    Console.WriteLine($"{customer}: {product} - {(total):f2}");
                    result += total;
                }
            }
            
            Console.WriteLine($"Total income: {result:F2}");
        }
    }
}
