using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main()
        {
            var firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            FindBetterCards(firstHand, secondHand);
            
        }

        private static void FindBetterCards(List<int> first, List<int> second)
        {
            bool isFirstWin = false;
            bool isSecondWin = false;
            int sumOfWinner = 0;
            for (int i = 0; i < first.Count; i++)
            {
                if (first.Count == 0)
                {

                    sumOfWinner = second.Sum();
                    isSecondWin = true;
                    break;
                }
                else if (second.Count == 0)
                {
                    sumOfWinner = first.Sum();
                    isFirstWin = true;
                    break;
                }
                else
                {
                    for (int j = i; j < second.Count; j++)
                    {
                        if (first[i] > second[j])
                        {
                            first.Add(first[i]);
                            first.RemoveAt(i);
                            first.Add(second[j]);
                            second.RemoveAt(j);
                            i--;
                            break;
                        }
                        else if (first[i] == second[j])
                        {
                            first.RemoveAt(i);
                            second.RemoveAt(j);
                            i--;
                            break;
                        }
                        else
                        {
                            second.Add(second[i]);
                            second.RemoveAt(j);
                            second.Add(first[j]);
                            first.RemoveAt(j);
                            i--;
                            break;
                        }

                    }
                    if (first.Count == 0)
                    {

                        sumOfWinner = second.Sum();
                        isSecondWin = true;
                        break;
                    }
                    else if (second.Count == 0)
                    {
                        sumOfWinner = first.Sum();
                        isFirstWin = true;
                        break;
                    }
                }
            }

            if (isFirstWin)
            {
                Console.WriteLine($"First player wins! Sum: {sumOfWinner}");
            }
            else if(isSecondWin)
            {
                Console.WriteLine($"Second player wins! Sum: {sumOfWinner}");
            }
        }
    }
}
