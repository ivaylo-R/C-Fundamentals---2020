using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUni_Exam_Results
{
    class Program
    {
        static void Main()
        {
            string input;
            var results = new Dictionary<string, Data>();
            int maxPoints = 0;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                if (input.Contains("banned"))
                {
                    var cmd = input.Split("-");
                    string name = cmd[0];
                    if (results.ContainsKey(name) && cmd[1] == "banned")
                    {
                        results[name].name.Remove(0);
                    }
                }
                else
                {

                    var cmd = input.Split("-");
                    string name = cmd[0];
                    string lang = cmd[1];
                    int points = int.Parse(cmd[2]);
                    
                    Data data = new Data(name, lang, points);
                    if (!results.ContainsKey(name))
                    {
                        results[name] = data;
                    }

                    else
                    {

                        if (points > maxPoints)
                        {
                            maxPoints = points;
                            results[name].points = points;
                        }
                    }
                }
            }

            Console.WriteLine("Results:");
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Value.Name} | {item.Value.Points}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in results)
            {
                
                Console.WriteLine($"{item.Value.Language} – {item.Value.Language.Count()}");
            }
        }


    }

    public class Data
    {
        public string name;
        public string language;
        public int points;
        public Data(string name, string language, int points)
        {
            this.name = name;
            this.language = language;
            this.points = points;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }
        public string Language
        {
            get
            {
                return language;
            }
            set 
            {
                language = value;
            }
        }
    }
}
