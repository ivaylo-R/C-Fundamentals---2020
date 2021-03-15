using System;

namespace _09.TextProcessing_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                string line = Console.ReadLine();
                int startName= line.IndexOf("@");
                int endName = line.IndexOf("|");
                string name = line.Substring(startName + 1, (endName - startName)-1);
                int startY = line.IndexOf("#");
                int endY = line.IndexOf("*");
                string age = line.Substring(startY + 1, (endY - startY)-1);

                Console.WriteLine($"{name} is {age} years old.");
                n--;
            } 


        }
    }
}
