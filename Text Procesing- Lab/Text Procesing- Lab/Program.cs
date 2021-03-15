using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Procesing__Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line=Console.ReadLine())!="end")
            {
                string reversed=" ";
                for (int i = line.Length-1; i >= 0; i--)
                {
                    reversed += line[i];
                }
                Console.WriteLine($"{line} ={reversed}");
            }
        }
    }
}
