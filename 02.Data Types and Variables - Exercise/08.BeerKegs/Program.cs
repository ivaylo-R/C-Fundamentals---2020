using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double maxValue = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                float volume = (float)(Math.PI * Math.Pow(radius, 2) * height);

                if (volume > maxValue)
                {
                    maxValue = volume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
