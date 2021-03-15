using System;
using System.Collections.Generic;

namespace _04.listOfProducts
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();
            AddProductsToList(products,count);
            products.Sort();
            PrintResults(products);
            
        }

        private static void PrintResults(List<string> output)
        {
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine($"{i+1}.{output[i]}");
            }
        }

        private static List <string> AddProductsToList(List<string> products, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string line = Console.ReadLine();
                products.Add(line);
            }
            return products;
        }
    }
}
