using System;

namespace _10.RageExpenss
{
    class Program
    {
        static void Main()
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());
            double headsetCrshTimes = lostGamesCount / 2;
            double mouseCrshTimes = lostGamesCount / 3;
            double keyboardCrshTimes = lostGamesCount / 6;
            double displayCrshdTimes = lostGamesCount / 2;

            double expenses = headset * headsetCrshTimes + mouseCrshTimes * mouse + keyboardCrshTimes * keyboard + displayCrshdTimes * display;
            Console.WriteLine($"Rage expenses: {expenses} lv.");
        }
    }
}
