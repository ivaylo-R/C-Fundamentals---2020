using System;

namespace aquarium2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = lenght * width * height;
            double volumeInLiters = volume * 0.001;
            double numberPercent = percent * 0.01;
            double fS = volumeInLiters * (1 - numberPercent);

            Console.WriteLine($"{fS:F3}");

        }
    }
}
