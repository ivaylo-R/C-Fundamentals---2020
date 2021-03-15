using System;
using System.Numerics;

namespace _11.SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            byte snowballs = byte.Parse(Console.ReadLine());
            BigInteger maxSnowBallValue = 0;
            short maxSnowBallSnow = 0;
            short maxSnowBallTime = 0;
            byte maxSnowBallQuality = 0;
            
            for (int i = 0; i < snowballs; i++)
            {
                short snowBallSnow = short.Parse(Console.ReadLine());
                short snowBallTime = short.Parse(Console.ReadLine());
                byte snowBallQuality = byte.Parse(Console.ReadLine());
                BigInteger snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);
                if (snowBallValue >= maxSnowBallValue)
                {
                    maxSnowBallValue = snowBallValue;
                    maxSnowBallSnow = snowBallSnow;
                    maxSnowBallTime = snowBallTime;
                    maxSnowBallQuality = snowBallQuality;

                }
            }

            Console.WriteLine($"{maxSnowBallSnow} : {maxSnowBallTime} = { maxSnowBallValue} ({maxSnowBallQuality})");
        }
    }
}
