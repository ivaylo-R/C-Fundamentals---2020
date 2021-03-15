using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demonsName = Console.ReadLine().Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            int health = 0;
            double damage = 0.0;
            var output = new Dictionary<string, Dictionary<int, double>>();

            for (int i = 0; i < demonsName.Length; i++)
            {
                health = GetDemonHealth(demonsName[i]);
                damage = GetDemonDamage(demonsName[i]);
            }

        }

        private static double GetDemonDamage(string v)
        {
            MatchCollection nums = Regex.Matches(v, @"[+]*[-]*\d+\.*\d*");
            double damage = 0.0;
            MatchCollection multiplyOrDivide = Regex.Matches(v, @"(?<star>\**)(?<line>\/*)");
            var multiply = multiplyOrDivide.Select(x => x.Groups["star"].Value).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                damage+= double.Parse(nums[i].ToString());
            }
            if (multiplyOrDivide.Count!=0)
            {
                
            }
            
            return damage;
            
        }

        private static int GetDemonHealth(string v)
        {
            MatchCollection symbols = Regex.Matches(v, @"[A-Za-z]");
            int health = 0;
            string healths = symbols.ToString();
            for (int i = 0; i < healths.Length; i++)
            {
                health += healths[i];
            }

            return health;
        }
    }
}
