using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] currStudent = Console.ReadLine().Split();
                string firstName = currStudent[0];
                string lastName = currStudent[1];
                decimal grade = decimal.Parse(currStudent[2]);
                Student myArticle = new Student(firstName, lastName, grade);
                students.Add(myArticle);

            }
            List <Student> output = students.OrderByDescending(x => x.Grade).ToList();
            output.ForEach(x => Console.WriteLine(x));
        }

    }
    public class Student
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public decimal Grade { get; set; }

        public Student(string firstName, string lastName, decimal grade)
        {
            this.FirstName = firstName;
            this.Lastname = lastName;
            this.Grade = grade;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.Lastname}: {this.Grade:F2}";
        }
    }
}
