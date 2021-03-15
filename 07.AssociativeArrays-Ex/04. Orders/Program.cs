using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main()
        {
            string line = string.Empty;
            var products = new Dictionary<string, Products>();
            while ((line=Console.ReadLine())!="buy")
            {
                var cmd = line.Split();
                string name = cmd[0];
                double price = double.Parse(cmd[1]);
                int quant = int.Parse(cmd[2]);
                Products product = new Products(name,price ,quant);
                
                if (!products.ContainsKey(name))
                {
                    products[name] = product;
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quantity += quant;
                }
            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Quantity*item.Value.Price:F2}");
            }
        }
    }
    public class Products
    {
        public string name;
        public double price;
        public int quantity;
        public Products(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
    }
}
