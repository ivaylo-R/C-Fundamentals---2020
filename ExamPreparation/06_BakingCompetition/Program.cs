using System;

namespace _06_BakingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakers = int.Parse(Console.ReadLine());
            
            int totalSweetCnt = 0;
            double totalSum = 0;
            

            for (int i = 0; i < bakers; i++)
            {
                string bakerName = Console.ReadLine();
                int cookiesCnt = 0;
                int cakesCnt = 0;
                int wafflesCnt = 0;
                string sweetName = Console.ReadLine();

                
                while ("Stop baking!" != sweetName)
                {
                    int sweetsCnt = int.Parse(Console.ReadLine());

                    switch (sweetName)
                    {
                        case "cookies":
                            cookiesCnt += sweetsCnt;
                            break;
                        case "cakes":
                            cakesCnt += sweetsCnt;
                            break;
                        case "waffles":
                            wafflesCnt += sweetsCnt;
                            break;
                    }
                    sweetName = Console.ReadLine();
                }

                totalSweetCnt += (cookiesCnt + cakesCnt + wafflesCnt);
                totalSum += (cookiesCnt * 1.5) + (cakesCnt * 7.80) + (wafflesCnt * 2.30);
                Console.WriteLine($"{bakerName} baked {cookiesCnt} cookies, {cakesCnt} cakes and {wafflesCnt} waffles.");
                
            }
            
            Console.WriteLine($"All bakery sold: {totalSweetCnt}");

            Console.WriteLine($"Total sum for charity: {totalSum:F2} lv.");

        }
    }
}
