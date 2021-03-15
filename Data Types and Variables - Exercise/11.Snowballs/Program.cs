using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {


            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger snowBallSnow = 0;
            BigInteger snowBallTime = 0;
            BigInteger snowBallQuality = 0;
            double snowBallValue = 0;
            double maxSnowBallValue = double.MinValue;
            BigInteger currentSnowBallSnow = 0;
            BigInteger currentSnowBallTime = 0;
            BigInteger currentSnowBallQuality = 0;
            for (BigInteger i = 1; i <= N; i++)
            {
                snowBallSnow = BigInteger.Parse(Console.ReadLine());
                snowBallTime = BigInteger.Parse(Console.ReadLine());
                snowBallQuality = BigInteger.Parse(Console.ReadLine());
                BigInteger currentValue = snowBallSnow / snowBallTime;
                snowBallValue =  Math.Pow((double)currentValue,(double) snowBallQuality);
                if (maxSnowBallValue <= snowBallValue)
                {
                    maxSnowBallValue = snowBallValue;
                    currentSnowBallSnow = snowBallSnow;
                    currentSnowBallTime = snowBallTime;
                    currentSnowBallQuality = snowBallQuality;
                }
            }
            Console.WriteLine($"{currentSnowBallSnow} : {currentSnowBallTime} = {maxSnowBallValue} ({currentSnowBallQuality})");
        }
    }
}
