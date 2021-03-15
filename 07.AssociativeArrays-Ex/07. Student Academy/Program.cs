using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            while (n!=0)
            {
                string name =Console.ReadLine();
                double grade= double.Parse(Console.ReadLine());
                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students[name] = new List<double> { grade };
                }
                n--;
            }
            
            foreach (var student in students.Where(x=>(x.Value.Sum()/x.Value.Count)>=4.50).OrderByDescending(x=>x.Value.Sum() / x.Value.Count))
            {
                Console.WriteLine($"{student.Key} -> {(student.Value.Sum()/student.Value.Count):f2}");
            }
        }
    }
}
