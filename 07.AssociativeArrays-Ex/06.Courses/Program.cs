using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = string.Empty;
            var students = new Dictionary<string, List<string>>();
            while ((inp=Console.ReadLine())!="end")
            {
                var cmd = inp.Split(" : ");
                string course = cmd[0];
                string student = cmd[1];
                if (!students.ContainsKey(course))
                {
                    students.Add(course, new List<string> { student });
                }
                else
                {
                    students[course].Add(student);
                }
            }
            var sortedDict = students.OrderByDescending(kvp => kvp.Value.Count());
            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                var sortedNames = item.Value.OrderBy(x=>x).ToList();
                foreach (var name in sortedNames)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
