using System;
using System.Text;

namespace _04_April_2020_Group_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string key =Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                var instructions = input.Split(">>>");
                string action = instructions[0];
                switch (action)
                {
                    case "Contains":
                        string substr = instructions[1];
                        if (key.Contains(substr))
                        {
                            Console.WriteLine($"{key} contains {substr}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string upperOrLower = instructions[1];
                        int startIndex = int.Parse(instructions[2]);
                        int EndIndex = int.Parse(instructions[3]);
                        if (upperOrLower.Contains("Upper"))
                        {
                            var sb = new StringBuilder();
                            for (int i = startIndex; i < EndIndex; i++)
                            {
                                sb.Append(key[i].ToString().ToUpper());
                            }
                            string substring = key.Substring(startIndex, EndIndex - startIndex);
                            key = key.Replace(substring, sb.ToString());
                        }
                        else if (upperOrLower.Contains("Lower"))
                        {
                            var sb = new StringBuilder();
                            for (int i = startIndex; i < EndIndex; i++)
                            {
                                sb.Append(key[i].ToString().ToLower());
                            }
                            string substring = key.Substring(startIndex, EndIndex - startIndex);
                            key = key.Replace(substring, sb.ToString());
                        }

                        Console.WriteLine(key);
                        break;
                    case "Slice":
                        int startI = int.Parse(instructions[1]);
                        int EndI = int.Parse(instructions[2]);
                        key = key.Remove(startI, EndI-startI);
                        Console.WriteLine(key);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
