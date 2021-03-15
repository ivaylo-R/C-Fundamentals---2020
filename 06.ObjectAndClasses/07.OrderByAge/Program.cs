using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main()
        {
            var input = new List<string>();
            List<Catalogue> output = new List<Catalogue>();
            string cmd = string.Empty;
            
            while ((cmd=Console.ReadLine())!="End")
            {
                input = cmd.Split().ToList();
                Catalogue catalogue = new Catalogue(input[0], input[1], int.Parse(input[2]));
                output.Add(catalogue);
            }
            var result = output.OrderBy(x => x.Age);
            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Catalogue
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }


        public Catalogue(string name,string ID, int age)
        {
            this.Name = name;
            this.ID = ID;
            this.Age = age;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.Name} with ID: {this.ID} is {this.Age} years old.");
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
