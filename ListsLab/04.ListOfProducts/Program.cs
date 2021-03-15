using System;
using System.Collections.Generic;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            AddProductsToList(list,n);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i+1}.{list[i]}");
            }
        }

        

        private static List <string> AddProductsToList(List<string> list,int n)
        {
            
            for (int i = 0; i < n; i++)
            {

                string product = Console.ReadLine();
                list.Add(product);
            }
            list.Sort();
            return list;
        }
    }
}
