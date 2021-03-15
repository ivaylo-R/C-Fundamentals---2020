using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = arr[0];
            int power = arr[1];

            int bombIndex = input.IndexOf(bomb);
            while (bombIndex!=-1)
            {
                int leftNums = bombIndex - power;
                int rightNums = bombIndex + power;
                if (rightNums > input.Count - 1)
                {
                    rightNums = input.Count - 1;
                }
                else if (leftNums < 0)
                {
                    leftNums = 0;
                }

                input.RemoveRange(leftNums, rightNums - leftNums + 1);

                bombIndex = input.IndexOf(bomb);
            }

            Console.WriteLine(input.Sum());
        }
    }
}
