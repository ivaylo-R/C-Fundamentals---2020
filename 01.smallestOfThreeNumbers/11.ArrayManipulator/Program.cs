using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "exchange":
                        int index = int.Parse(command[1]);
                        ExchangePartsOfArr(inputArr, index);
                        break;
                    case "max":
                        break;
                    case "min":
                        break;
                    case "first":
                        break;
                    case "last":
                        break;
                }

                command = Console.ReadLine().Split();
            }
            PrintResult(inputArr);
        }

        private static int [] ExchangePartsOfArr(int[] inputArr ,int index)
        {
            int[] temp = new int[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                temp[i] = inputArr[(index + i + 1)];
                
            }
            return temp;
        }

        private static void PrintResult(int[] inputArr)
        {
            Console.WriteLine(inputArr);
        }
    }
}
