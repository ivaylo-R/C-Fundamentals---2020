using System;

namespace Data_Types_and_Variables___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int step = 1;
            int number = start;
            if (start > end)
            {
                start = start ^ end;
                end = end ^ start;
                start = start ^ end;
                step = -1;
            }

            string result = "";
            for (int i = start; i <= end; i+=1)
            {
                result += (char)number + " ";

                number += step;
            }
            Console.WriteLine(result);
        }
    }
}
