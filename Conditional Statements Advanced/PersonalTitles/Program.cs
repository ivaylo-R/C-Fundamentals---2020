using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double years = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            if (gender=="m" && years>=16)
            {
                Console.WriteLine("Mr.");
            }
            else if (gender == "m"&& years <= 16)
            {
                Console.WriteLine("Master");
            }
            else if (gender == "f" && years >= 16)
            {
                Console.WriteLine("Ms.");
            }
            else
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
