using System;
using System.Linq;
using System.Text;

namespace _9_August_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string line;
            while ((line = Console.ReadLine()) != "Sign up")
            {
                var cmd = line.Split();
                string action = cmd[0];
                if (action == "Case")
                {
                    if (cmd[1] == "lower")
                    {
                        var sb = new StringBuilder();
                        for (int i = 0; i < username.Length; i++)
                        {
                            sb.Append(username[i].ToString().ToLower());
                        }
                        Console.WriteLine($"{username = sb.ToString()}");
                    }
                    else
                    {
                        var sb = new StringBuilder();
                        for (int i = 0; i < username.Length; i++)
                        {
                            sb.Append(username[i].ToString().ToUpper());
                        }
                        Console.WriteLine($"{username = sb.ToString()}");
                    }
                }
                else if (action == "Reverse")
                {
                    int endIndex = int.Parse(cmd[2]);
                    int startIndex = int.Parse(cmd[1]);
                    var substringReversed = new StringBuilder();
                    if (startIndex >= 0 && startIndex < username.Length && endIndex > 0 && endIndex < username.Length)
                    {
                        string substring = username.Substring(startIndex, endIndex);

                        for (int i = substring.Length-1; i >=0 ; i--)
                        {
                            substringReversed.Append(substring[i]);
                        }
                        Console.WriteLine(substringReversed);
                    }
                }
                else if (action == "Cut")
                {
                    string substring = cmd[1];
                    if (!username.Contains(substring))
                    {
                        Console.WriteLine($"The word {username} doesn't contain {substring}.");
                        continue;
                    }
                    username = username.Remove(username.IndexOf(substring), substring.Length);
                    Console.WriteLine(username);
                }
                else if (action == "Replace")
                {
                    char oldChar = char.Parse(cmd[1]);
                    char newChar = '*';
                    if (username.Contains(oldChar))
                    {
                        while (username.Contains(oldChar))
                        {
                            username = username.Replace(oldChar, newChar);
                        }
                    }
                    Console.WriteLine(username);
                }
                else if (action == "Check")
                {
                    char charExist = char.Parse(cmd[1]);

                    if (username.Contains(charExist))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {charExist}.");
                    }
                    
                }
            }
        }
    }
}
