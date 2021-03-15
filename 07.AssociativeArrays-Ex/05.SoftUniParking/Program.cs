using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string,string>();
            while (n!=0)
            {
                var cmd =Console.ReadLine().Split();
                if (cmd.Length==3)
                {
                    string name = cmd[1];
                    string license = cmd[2];
                    if (!dict.ContainsKey(name))
                    {
                        dict[name] = license;
                        Console.WriteLine($"{name} registered {license} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }

                }
                else if (cmd.Length==2)
                {
                    string name = cmd[1];
                    if (!dict.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        dict.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    
                }
                n--;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
