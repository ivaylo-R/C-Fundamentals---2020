using System;
using System.Linq;

namespace _02.NumberArray
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string line = string.Empty;
            while ((line = Console.ReadLine()) != "End")
            {
                var cmd = line.Split();
                if (cmd[0] == "Switch")
                {
                    sbyte index = sbyte.Parse(cmd[1]);
                    if (index >= 0 && index <= arr.Length - 1)
                    {
                        if (arr[index] < 0)
                        {
                            arr[index] *= -1;
                        }
                        else
                        {
                            arr[index] *= -1;
                        }
                    }
                }
                else if (cmd[0] == "Change")
                {
                    int index = int.Parse(cmd[1]);
                    int value = int.Parse(cmd[2]);
                    if (index >= 0 && index <= arr.Length - 1)
                    {
                        arr[index] = value;
                    }
                }
                else if (cmd[0] == "Sum" && cmd[1] == "Positive")
                {
                    int sum = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] > 0)
                        {
                            sum += arr[i];
                        }
                    }
                    Console.WriteLine(sum);
                }
                else if (cmd[0] == "Sum" && cmd[1] == "Negative")
                {
                    int sum = 0;

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] < 0)
                        {
                            sum += arr[i];
                        }
                    }
                    Console.WriteLine(sum);
                }
                else if (cmd[1] == "All" && cmd[0] == "Sum")
                {
                    int sum = 0;

                    for (int i = 0; i < arr.Length; i++)
                    {
                        sum += arr[i];
                    }
                    Console.WriteLine(sum);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>=0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
