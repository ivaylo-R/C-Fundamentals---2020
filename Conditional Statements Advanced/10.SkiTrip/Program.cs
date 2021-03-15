using System;

namespace _10.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();
            double total = 0.00;
            days -= 1;
            if (room == "room for one person")
            {
                if (days < 10)
                {
                    total = days * 18.00;
                    switch (grade)
                    {
                        case "positive":
                            Console.WriteLine($"{total + (total * 0.25):F2}");
                            break;
                        case "negative":
                            Console.WriteLine($"{total - (total * 0.10):F2}");
                            break;
                    }
                }
                else if (days >= 10 && days <= 15)
                {
                    total = days * 18.00;
                    switch (grade)
                    {
                        case "positive":
                            Console.WriteLine($"{total + (total * 0.25):F2}");
                            break;
                        case "negative":
                            Console.WriteLine($"{total - (total * 0.10):F2}");
                            break;
                    }
                }
                else if (days > 15)
                {
                    total = days * 18.00;
                    switch (grade)
                    {
                        case "positive":
                            Console.WriteLine($"{total + (total * 0.25):F2}");
                            break;
                        case "negative":
                            Console.WriteLine($"{total - (total * 0.10):F2}");
                            break;
                    }
                }
            }
            else if (room == "apartment")
            {
                if (days < 10)
                {
                    total = (days * 25.00) * 0.7;
                    switch (grade)
                    {
                        case "positive":
                            Console.WriteLine($"{total + (total * 0.25):F2}");
                            break;
                        case "negative":
                            Console.WriteLine($"{total - (total * 0.10):F2}");
                            break;
                    }
                }
                else if (days >= 10 && days < 15)
                {
                    total = (days * 25.00) * 0.65;
                    switch (grade)
                    {
                        case "positive":
                            Console.WriteLine($"{total + (total * 0.25):F2}");
                            break;
                        case "negative":
                            Console.WriteLine($"{total - (total * 0.10):F2}");
                            break;
                    }
                }
                else
                {
                    total = (days * 25.00) * 0.50;
                    switch (grade)
                    {
                        case "positive":
                            Console.WriteLine($"{total + (total * 0.25):F2}");
                            break;
                        case "negative":
                            Console.WriteLine($"{total - (total * 0.10):F2}");
                            break;
                    }
                }
            }
            else if (room == "president apartment") 
            {
                if (days < 10)
                {
                    total = (days * 35.00) * 0.9;
                    switch (grade)
                    {
                        case "positive":
                            Console.WriteLine($"{total + (total * 0.25):F2}");
                            break;
                        case "negative":
                            Console.WriteLine($"{total - (total * 0.10):F2}");
                            break;
                    }
                }
                else if (days >= 10 && days < 15)
                {
                    total = (days * 35.00) * 0.85;
                    switch (grade)
                    {
                        case "positive":
                            Console.WriteLine($"{total + (total * 0.25):F2}");
                            break;
                        case "negative":
                            Console.WriteLine($"{total - (total * 0.10):F2}");
                            break;
                    }
                }
                else
                {
                    total = (days * 35.00) * 0.80;
                    switch (grade)
                    {
                        case "positive":
                            Console.WriteLine($"{total + (total * 0.25):F2}");
                            break;
                        case "negative":
                            Console.WriteLine($"{total - (total * 0.10):F2}");
                            break;
                    }
                }
                
            }
        }
    }
}
