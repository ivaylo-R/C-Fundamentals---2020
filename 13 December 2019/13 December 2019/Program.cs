using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _13_December_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            string line;
            while ((line = Console.ReadLine()) != "For Azeroth")
            {
                var cmd = line.Split();
                string action = cmd[0];
                if (action == "GladiatorStance")
                {
                    var sb = new StringBuilder();
                    for (int i = 0; i < text.Length; i++)
                    {
                        sb.Append(text[i].ToString().ToUpper());
                    }
                    text = sb.ToString();
                    Console.WriteLine(text);
                }
                else if (action == "DefensiveStance")
                {
                    var sb = new StringBuilder();
                    for (int i = 0; i < text.Length; i++)
                    {
                        sb.Append(text[i].ToString().ToLower());
                    }
                    text = sb.ToString();
                    Console.WriteLine(text);
                }
                else if (action == "Dispel")
                {
                    int index = int.Parse(cmd[1]);
                    char letter = char.Parse(cmd[2]);
                    if (index >= 0 && index <= text.Length)
                    {
                        text = text.Replace(text[index], letter);
                        Console.WriteLine("Success!");
                        continue;
                    }
                    Console.WriteLine($"Dispel too weak.");
                }
                else if (action == "Target")
                {
                    if (cmd[1] == "Change")
                    {
                        string oldSubstring = cmd[2];
                        string NewSubstring = cmd[3];
                        

                        if (text.IndexOf(oldSubstring)>=0&& text.IndexOf(oldSubstring)<text.Length)
                        {
                            text = text.Replace(text.Substring(text.IndexOf(oldSubstring), oldSubstring.Length), NewSubstring);
                            Console.WriteLine(text);
                        }
                        
                    }
                    else
                    {
                        string substring = cmd[2];
                        text = text.Remove(text.IndexOf(substring), substring.Length);
                        Console.WriteLine(text);

                    }

                }

                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }

        }
    }
}
