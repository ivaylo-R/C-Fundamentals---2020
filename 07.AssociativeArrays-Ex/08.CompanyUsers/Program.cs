using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main()
        {
            string input;
            var companies = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmd = input.Split(" -> ");
                string company = cmd[0];
                string ID = cmd[1];
                if (companies.ContainsKey(company))
                {
                    if (!companies[company].Contains(ID))
                    {
                        companies[company].Add(ID);
                    }
                    
                }
                else
                {
                    companies[company] = new List<string> { ID };
                }
            }
            foreach (var company in companies.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{company.Key}");
                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
