using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            bool iSSpecialNum = false;
            for (int digit = 1; digit <= n; digit++)
            {
                int currentDigit = digit;
                while (currentDigit> 0)
                {
                    total += currentDigit % 10;
                    currentDigit /= 10;
                }
                if ((total == 5) || (total == 7) || (total == 11))
                {
                    iSSpecialNum = true;
                }
                 
                Console.WriteLine("{0} -> {1}", digit, iSSpecialNum);
                total = 0;
                iSSpecialNum = false;
                
            }

        }
    }
}
