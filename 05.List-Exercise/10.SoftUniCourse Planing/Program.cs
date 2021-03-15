using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCourse_Planing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',' };
            List<string> input = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries).ToList();

            string line = string.Empty;
            while ((line = Console.ReadLine()) != "course start")
            {
                string[] lineSplitted = line.Split(':').ToArray();

                string command = lineSplitted[0];
                if (command == "Add")
                {
                    string lessonTitle = lineSplitted[1];

                    if (!(input.Contains(lessonTitle)))
                    {
                        input.Add(lessonTitle);
                    }
                }
                else if (command == "Insert")
                {
                    string lessonTitle = lineSplitted[1];
                    int index = int.Parse(lineSplitted[2]);
                    if (!(input.Contains(lessonTitle)))
                    {
                        input.Insert(index, lessonTitle);
                    }


                }
                else if (command == "Remove")
                {
                    string lessonTitle = lineSplitted[1];
                    if (input.Contains(lessonTitle))
                    {
                        input.Remove(lessonTitle);
                    }
                    else if (input.Contains($"{lessonTitle}-Exercise"))
                    {
                        input.Remove($"{lessonTitle}-Exercise");
                    }
                }

                else if (command == "Swap")
                {
                    string lessonTitle1 = lineSplitted[1];
                    string lessonTitle2 = lineSplitted[2];
                    if (input.Contains(lessonTitle2) && input.Contains(lessonTitle1))
                    {
                        
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == lessonTitle1)
                            {
                                input[i] = lessonTitle2;
                                if (input.Contains($"{lessonTitle1}-Exercise"))
                                {
                                    input.RemoveAt(input.IndexOf($"{lessonTitle1}-Exercise"));
                                    input.Insert(i+1, $"{lessonTitle1}-Exercise");
                                }
                            }
                            else if (input[i] == lessonTitle2)
                            {
                                input[i] = lessonTitle1;
                                if (input.Contains($"{lessonTitle1}-Exercise"))
                                {
                                    input.RemoveAt(input.IndexOf($"{lessonTitle1}-Exercise"));
                                    input.Insert(i + 1, $"{lessonTitle1}-Exercise");
                                }
                            }
                        }
                    }
                    if (input.Contains($"{lessonTitle2}-Exercise"))
                    {
                        input.RemoveAt(input.IndexOf($"{lessonTitle2}-Exercise"));
                        input.Insert(input.IndexOf(lessonTitle2)+1, $"{lessonTitle2}-Exercise");
                        
                    }
                }
                else if (command == "Exercise")
                {
                    string lessonTitle = lineSplitted[1];
                    if (input.Contains(lessonTitle))
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == lessonTitle)
                            {
                                input[i] += "-Exercise";
                            }
                        }
                    }
                    else
                    {
                        input.Add(lessonTitle);
                        input.Add(lessonTitle + "-Exercise");
                    }
                }


            }

            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i+1}.{input[i]}");
            }
        }
    }
}
