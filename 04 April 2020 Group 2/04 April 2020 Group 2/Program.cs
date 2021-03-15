using System;
using System.Linq;
using System.Text;

namespace _04_April_2020_Group_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            string line;
            var sb = new StringBuilder();
            string sbAsString=string.Empty;
            while ((line = Console.ReadLine()) != "Done")
            {
                if (line == "TakeOdd")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            sb.Append(input[i]);

                        }
                    }
                    Console.WriteLine(sb);
                }
                else
                {
                    var cmd = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (cmd[0] == "Cut")
                    {
                        int index = int.Parse(cmd[1]);
                        int length = int.Parse(cmd[2]);
                        int test = index + length;
                        if (test<=sb.Length)
                        {
                            sb = sb.Remove(index, length);
                            Console.WriteLine(sb);
                        }
                        else
                        {
                            if (index<sb.Length && index>0)
                            {
                                sb = sb.Remove(index, sb.Length - 1);
                                Console.WriteLine(sb);
                            }
                            
                        }
                        
                    }
                    else if (cmd[0] == "Substitute")
                    {
                        
                        if (sb.ToString().Contains(cmd[1]))
                        {
                           sb.Replace(cmd[1], cmd[2]);
                           Console.WriteLine(sb);
                        }

                        else
                        {
                            Console.WriteLine("Nothing to replace!");

                        }
                    }

                }
            }
            Console.WriteLine($"Your password is: {sb}");
        }
    }
}
