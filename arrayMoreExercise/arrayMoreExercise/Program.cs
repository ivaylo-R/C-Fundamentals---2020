using System;
using System.Linq;

namespace arrayMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] values = new int[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                char[] symbol = name.ToCharArray();
                
                for (int j = 0; j < symbol.Length; j++)
                {
                    int currentSymbol = symbol[j];
                    int symbolAsNum = (int)currentSymbol;
                    int sum = 0;
                    if (currentSymbol == 'A' || currentSymbol == 'a' || currentSymbol == 'E' || currentSymbol == 'e' || currentSymbol == 'O' || currentSymbol == 'o' || currentSymbol == 'U' || currentSymbol == 'u' || currentSymbol == 'I' || currentSymbol == 'i')
                    {
                        symbolAsNum *= name.Length;
                        sum += symbolAsNum;
                    }
                    else
                    {
                        symbolAsNum /= name.Length;
                        sum += symbolAsNum;
                    }
                    values[i]+=sum;
                }
            }
            Array.Sort(values);
            for (int i = 0; i < values.Length; i++)
            {
                int currentSum = values[i];
                Console.WriteLine(currentSum);
            }
        }
    }
}
