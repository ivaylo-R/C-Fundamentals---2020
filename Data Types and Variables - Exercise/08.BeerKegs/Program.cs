using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            string model = string.Empty;
            double maxSum = double.MinValue;
            bool isMax = false;
            string biggestModel = string.Empty;
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                model =Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                sum = Math.PI * (radius * radius) * height;
                if (maxSum<sum)
                {
                    maxSum=sum;
                    isMax = true;
                    biggestModel = model;
                }
                
            }
            if (isMax)
            {
                Console.WriteLine(biggestModel);
            }
            

        }
    }
}
