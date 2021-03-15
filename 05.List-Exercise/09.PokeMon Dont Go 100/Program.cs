using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepJuly
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int output = 0;
            while (input.Count > 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());
                int value = 0;
                if (indexToRemove < 0)
                {
                    //here we get the value of the index that we want to remove
                    value = input[0];
                    input[0] = input[input.Count - 1];
                    output += value;
                }
                else if (indexToRemove > input.Count - 1)
                {
                    //here we get the value of the index that we want to remove
                    value = input[input.Count - 1];
                    input[input.Count - 1] = input[0];
                    output += value;
                }
                else
                {
                    //here we get the value of the index that we want to remove
                    value = input.ElementAt(indexToRemove);
                    input.RemoveAt(indexToRemove);
                    output += value;
                }

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= value)
                    {
                        input[i] += value;
                    }
                    else if (input[i] > value)
                    {
                        input[i] -= value;
                    }
                }

            }
            Console.WriteLine(output);
        }
    }
}