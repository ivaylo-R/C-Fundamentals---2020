using System;
using System.Collections.Generic;

namespace Basic_Syntax_Con._Statements_And_Loops_more_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                int num=int.Parse(Console.ReadLine());
                list.Add(num);
            }
            list.Sort();
            list.Reverse();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
