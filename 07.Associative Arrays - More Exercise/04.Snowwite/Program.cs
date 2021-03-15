using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwite
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            var dwarfs = new Dictionary<string, Dwarfs>();
            while ((line = Console.ReadLine()) != "Once upon a time")
            {
                var tokens = line.Split(new string[] { " <:> "},StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string hatColor = tokens[1];
                int physics = int.Parse(tokens[2]);
                if (!dwarfs.ContainsKey(name))
                {
                    dwarfs.Add(name, new Dwarfs(name, hatColor, physics));
                }
                if (dwarfs.ContainsKey(name) && dwarfs[name].HatColor != hatColor)
                {
                    dwarfs[name] = new Dwarfs(name, hatColor, physics);
                }
                if (dwarfs.ContainsKey(name) && dwarfs[name].HatColor == hatColor && dwarfs[name].Physics != physics)
                {
                    if (dwarfs[name].Physics < physics)
                    {
                        dwarfs[name].Physics = physics;
                    }
                }
            }

            PrintResult(dwarfs);

        }

        private static void PrintResult(Dictionary<string, Dwarfs> dwarfs)
        {
            foreach (var dwarf in dwarfs.OrderByDescending(x=>x.Value.Physics).ThenBy(x=>x.Value.HatColor.Count()))
            {
                Console.WriteLine($"({dwarf.Value.HatColor}) {dwarf.Value.Name} <-> {dwarf.Value.Physics}");
            }
        }
    }
    public class Dwarfs
    {
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }

        public Dwarfs(string name, string hatColor,int physics)
        {
            Name = name;
            HatColor = hatColor;
            Physics = physics;
        }
    }
}
