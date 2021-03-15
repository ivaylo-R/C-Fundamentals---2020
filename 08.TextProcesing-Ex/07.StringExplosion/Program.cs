using System;
using System.Linq;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();
            int explosionStrength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (current == '>')
                {
                    explosionStrength += int.Parse(input[i + 1].ToString());
                    sb.Append(current);
                }
                else if (explosionStrength == 0)
                {
                    sb.Append(current);
                }
                else
                {
                    explosionStrength--;
                }
            }
            
            Console.WriteLine(sb);
        }
    }
}
