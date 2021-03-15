using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] lineArr = line.Split().ToArray();
                string command = lineArr[0];
                if (command == "exchange")
                {
                    int index = int.Parse(lineArr[1]);
                    if (index > input.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int [] newArr = ExchangeIndex(index, input);
                    }
                }
                if (command== "max" || command=="max")
                {
                    if (lineArr[1]=="odd")
                    {
                        MaxOdd(input);
                    }
                    else if (lineArr[1] == "even")
                    {
                        MaxEven(input);
                    }
                }
                if (command == "min" || command == "min")
                {
                    if (lineArr[1] == "odd")
                    {
                        MinOdd(input);
                    }
                    else if (lineArr[1] == "even")
                    {
                        MinEven(input);
                    }
                }
                line = Console.ReadLine();
            }
        }

        private static string MinEven(int[] lineArr)
        {
            int bestIndex = -1;
            bool evenExistt = false;
            for (int i = 0; i < lineArr.Length; i++)
            {
                int curr = lineArr[i];
                if (curr % 2 == 0 && bestIndex<i)
                {
                    if (curr==lineArr[i-1])
                    {
                        bestIndex = i;
                        return bestIndex.ToString();
                    }
                    bestIndex = i;
                    evenExistt = true;
                }
            }
            if (!evenExistt)
            {
                return "No matches";
            }
            return bestIndex.ToString();
        }

        private static string MinOdd(int [] lineArr)
        {
            int bestIndex = -1;
            bool oddExistt = false;
            for (int i = 0; i < lineArr.Length; i++)
            {
                int curr = lineArr[i];
                if (curr % 2 == 1 && bestIndex < i)
                {
                    if (curr == lineArr[i - 1])
                    {
                        bestIndex = i;
                        return bestIndex.ToString();
                    }
                    bestIndex = i;
                    oddExistt = true;
                }
            }
            if (!oddExistt)
            {
                return "No matches";
            }
            return bestIndex.ToString();
        }

        private static string MaxEven(int [] lineArr)
        {
            int bestIndex = -1;
            bool evenExistt = false;
            for (int i = 0; i < lineArr.Length; i++)
            {
                int curr = lineArr[i];
                if (curr % 2 == 0 && bestIndex < i)
                {
                    if (curr == lineArr[i - 1])
                    {
                        bestIndex = i;
                        return bestIndex.ToString();
                    }
                    bestIndex = i;
                    evenExistt = true;
                }
            }
            if (!evenExistt)
            {
                return "No matches";
            }
            return bestIndex.ToString();
        }

        private static string MaxOdd(int [] lineArr)
        {
            int max = int.MinValue;
            int bestIndex = 0;
            for (int i = 0; i < lineArr.Length; i++)
            {
                int curr = lineArr[i];
                if (curr%2==1 && curr>=max)
                {
                    
                    if (curr==max)
                    {
                        bestIndex = i;
                        return bestIndex.ToString();
                    }

                    max = curr;
                }
            }
            if (max==int.MinValue)
            {
                return "No matches";
            }
            return max.ToString();
        }

        private static int[] ExchangeIndex(int index, int[] input)
        {
            int[] newArr = new int[input.Length];
            int inputLength = input.Length - (input.Length-1);
            for (int i = index + 1; i < input.Length; i++)
            {
                int currNum = input[i];
                newArr[i - (index + 1)] = currNum;
            }
            for (int i = newArr.Length - 1; i > index + 1; i--)
            {
                
                newArr[i] = input[inputLength];
                inputLength--;

            }
            return newArr;
        }
    }
}
