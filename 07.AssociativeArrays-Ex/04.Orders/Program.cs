using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            var quantity = new Dictionary<string, double>();
            var price = new Dictionary<string, double>();
            
            while ((line=Console.ReadLine())!="buy")
            {
                var cmd = line.Split();
                string name = cmd[0];
                double currPrice = double.Parse(cmd[1]);
                double currQuantity = double.Parse(cmd[2]);
                if (!price.ContainsKey(name))
                {
                    price[name] = currPrice;
                    quantity[name] = currQuantity;
                }
                else
                {
                    price[name] = currPrice;
                    quantity[name] += currQuantity;
                }
                
            }
            foreach (var item in price)
            {
                double total = item.Value * quantity[item.Key];
                Console.WriteLine($"{item.Key} -> {total:F2}");
            }
        }
    }
}
