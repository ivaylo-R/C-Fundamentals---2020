using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SnowWhiteNewWay
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            var dwarfs = new Dictionary<string, int>();
            while ((line = Console.ReadLine()) != "Once upon a time")
            {
                var tokens = line.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
                string nameColor = tokens[0] + ":" + tokens[1];
                int physics = int.Parse(tokens[2]);

                if (!dwarfs.ContainsKey(nameColor))
                {
                    dwarfs.Add(nameColor, physics);
                }

                if (dwarfs[nameColor]<physics)
                {
                    dwarfs[nameColor] = physics;
                }
            }
            
            PrintCollection(dwarfs);
        }

        private static void PrintCollection(Dictionary<string, int> dwarfs)
        {
            var dwarfsSplitted = new Dictionary<Dictionary<string, string>, int>();
            foreach (var item in dwarfs)
            {
                var arr = item.Key.Split(":");
                dwarfsSplitted.Add(new Dictionary<string, string> { { arr[0], arr[1] } },item.Value);
            }
            foreach (var dwarf in dwarfsSplitted.OrderByDescending(y=>y.Value).ThenBy(y=>y.Key.Count()))
            {
                
                foreach (var item in dwarf.Key)
                {
                Console.WriteLine($"({item.Value}) {item.Key} <-> {dwarf.Value}");
                    
                }
            }
        }
    }
}
