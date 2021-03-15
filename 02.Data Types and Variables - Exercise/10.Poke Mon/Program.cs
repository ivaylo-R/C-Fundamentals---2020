using System;

namespace _10.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            byte exhaustionY = byte.Parse(Console.ReadLine());
            decimal halfOfPower = pokePowerN * 0.5m;
            int pokedTargetCounter = 0;
            while (pokePowerN >= distanceM)
            {
                pokePowerN -= distanceM;
                pokedTargetCounter++;
                if (pokePowerN == halfOfPower)
                {
                    if (pokePowerN > 0 && exhaustionY>0)
                    {
                        pokePowerN /= exhaustionY;
                    }
                }
            }

            Console.WriteLine(pokePowerN);
            Console.WriteLine(pokedTargetCounter);

        }
    }
}
