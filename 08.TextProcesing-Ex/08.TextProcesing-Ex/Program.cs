using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _08.TextProcesing_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            var output = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                
                if (current.Length >= 3 && current.Length <= 16)
                {
                    bool isValid = true;
                    for (int j = 0; j < current.Length; j++)
                    {
                        
                        if (!(char.IsLetterOrDigit(current[j]) || current[j] == '-' || current[j] == '_'))
                        {
                            isValid = false;
                            
                        }
                    }

                    if (isValid)
                    {
                        output.Add(current); ;
                    }
                }
               
            }
            Console.WriteLine(String.Join(Environment.NewLine,output));
        }
    }
}
