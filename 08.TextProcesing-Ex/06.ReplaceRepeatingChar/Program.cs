using System;
using System.Text;

namespace _06.ReplaceRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string text =Console.ReadLine();
            var sb = new StringBuilder();
            int counter = 0;
            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i]==text[i+1])
                {
                    if (i<=startIndex)
                    {
                        startIndex = i;
                        
                    }
                    counter++;
                    
                }
                else
                {
                    sb.Append(text[i]);
                    text = text.Remove(startIndex, counter+1);
                    counter = 0;
                    i = -1;
                }
               
            }
            sb.Append(text.Substring(text.Length-1,1));
            Console.WriteLine(sb);
        }
    }
}
