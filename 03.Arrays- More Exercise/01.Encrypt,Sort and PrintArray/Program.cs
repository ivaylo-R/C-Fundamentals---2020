using System;

namespace _01.Encrypt_Sort_and_PrintArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                char[] symbol = name.ToCharArray();
                int sum = 0;
                for (int j = 0; j < symbol.Length; j++)
                {
                    int currentSymbol = symbol[j];
                    int symbolAsNum = (int)currentSymbol;
                    if (currentSymbol == 'A' || currentSymbol == 'a' || currentSymbol == 'E' || currentSymbol == 'e' || currentSymbol == 'O' || currentSymbol == 'o' || currentSymbol == 'U' || currentSymbol == 'u' || currentSymbol == 'I' || currentSymbol == 'i')
                    {
                        symbolAsNum *= symbol.Length;
                        sum += symbolAsNum;
                    }
                    else
                    {
                        symbolAsNum /= symbol.Length;
                        sum += symbolAsNum;
                    }

                   
                }

                result[i] += sum;
            }
            Array.Sort(result);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);

            }

        }
    }
}