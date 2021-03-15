using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double countFirst = 0.0;
            double countSecond = 0.0;
            double countThird = 0.0;
            double countFourth = 0.0;
            double countFifth = 0.0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num<200)
                {
                    countFirst++;
                }
                else if (num>=200 &&num<=399)
                {
                    countSecond++;
                }
                else if (num>=400 && num<=599)
                {
                    countThird ++;
                }
                else if (num>=600 && num <=799)
                {
                    countFourth++;
                }
                else
                {
                    countFifth++;
                }
            }

            double p1 = countFirst * 1.0 / n * 100;
            double p2 = countSecond * 1.0 / n * 100;
            double p3 = countThird * 1.0 / n * 100;
            double p4 = countFourth * 1.0 / n * 100;
            double p5 = countFifth * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
