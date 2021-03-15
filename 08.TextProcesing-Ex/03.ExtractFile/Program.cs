using System;
using System.Text; 


namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string text =Console.ReadLine();
            int betweeenIndex = text.IndexOf(".");
            int startIndex = text.LastIndexOf("\\");
            var fileName = new StringBuilder();
            var extension = new StringBuilder();
            for (int i = startIndex+1; i < betweeenIndex; i++)
            {
                fileName.Append(text[i]);
            }
            for (int i = betweeenIndex+1; i < text.Length; i++)
            {
                extension.Append(text[i]);
            }
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
