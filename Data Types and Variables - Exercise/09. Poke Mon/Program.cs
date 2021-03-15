using System;

namespace _09._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int target = 0;
            double fiftyPercentOfN = N * 0.5;
            int exhaustFactory = 0;
            if (M > N)
            {
                Console.WriteLine(N);
                Console.WriteLine(target);
            }
            else
            {


                while (N >= M)
                {
                    
                    if (N-M == fiftyPercentOfN && Y != 0)
                    {
                        N = (N - M) / Y;
                    }
                    else
                    {
                        N -= M;
                    }

                    target++;
                    
                }
                Console.WriteLine(N);
                Console.WriteLine(target);
            }
        }
    }
}
