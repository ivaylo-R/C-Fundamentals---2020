using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double total = 0;
            double num = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentSeq = input[i];

                char firstLetter = currentSeq[0];
                char lastLetter = currentSeq[currentSeq.Length - 1];
                int indexOfLastNum = currentSeq.Length - 2;
                string numAsText = currentSeq.Substring(1, indexOfLastNum);
                num = double.Parse(numAsText);
                if (Char.IsUpper(firstLetter))
                {
                    int firstLetterAsNum = (int)firstLetter - 64;
                    num /= firstLetterAsNum;
                }
                else
                {
                    int firstLetterAsNum = (int)firstLetter - 96;
                    num *= firstLetterAsNum;
                }
                if (Char.IsUpper(lastLetter))
                {
                    int lastAsNm = (int)lastLetter - 64;
                    num -= lastAsNm;
                }

                else
                {
                    int lastAsNum = (int)lastLetter - 96;
                    num += lastAsNum;
                }


                total += num;
            }

            Console.WriteLine($"{total:f2}");
        }
    }
}
