using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string languages= Console.ReadLine();
            switch (languages)
            {
                case "England":
                case "USA": Console.WriteLine("English"); break;
                case "Spain":
                case "Mexico":
                case "Argentina": Console.WriteLine("Spanish"); break;
                default: Console.WriteLine("unknown"); break;
            }



        }
    }
}
