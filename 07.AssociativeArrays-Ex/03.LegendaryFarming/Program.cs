using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            
            var keyMaterials = new Dictionary<string, int>();
            var junks = new Dictionary<string, int>();
            string material = string.Empty;
            int quantity = 0;
            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();
                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(input[i]);
                    }
                    else
                    {
                        material = input[i].ToLower();
                        if (material == "shards" || material == "fragments" || material == "motes")
                        {
                            if (!keyMaterials.ContainsKey(material))
                            {
                                keyMaterials[material] = quantity;
                                if ((keyMaterials.ContainsKey("motes") || keyMaterials.ContainsKey("fragments") || keyMaterials.ContainsKey("shards")) && keyMaterials[material] >= 250)
                                {
                                    if (material == "motes")
                                    {
                                        Console.WriteLine("Dragonwrath obtained!");
                                        keyMaterials["motes"] -= 250;
                                    }
                                    else if (material == "fragments")
                                    {
                                        Console.WriteLine("Valanyr obtained!");
                                        keyMaterials["fragments"] -= 250;
                                    }
                                    else if (material == "shards")
                                    {
                                        Console.WriteLine("Shadowmourne obtained!");
                                        keyMaterials["shards"] -= 250;
                                    }
                                    var sortedKeyMat = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
                                    foreach (var item in sortedKeyMat)
                                    {
                                        Console.WriteLine($"{item.Key}: {item.Value}");
                                    }

                                    var sortedJunks = junks.OrderBy(x => x.Key);
                                    foreach (var item in sortedJunks)
                                    {
                                        Console.WriteLine($"{item.Key}: {item.Value}");
                                    }
                                    return;
                                }
                            }
                            else
                            {
                                keyMaterials[material] += quantity;
                                if ((keyMaterials.ContainsKey("motes") || keyMaterials.ContainsKey("fragments") || keyMaterials.ContainsKey("shards")) && keyMaterials[material] >= 250)
                                {
                                    if (!keyMaterials.ContainsKey("motes"))
                                    {
                                        keyMaterials.Add("motes", 0);
                                    }
                                    if (!keyMaterials.ContainsKey("fragments"))
                                    {
                                        keyMaterials.Add("fragments", 0);
                                    }
                                    if (!keyMaterials.ContainsKey("shards"))
                                    {
                                        keyMaterials.Add("shards", 0);
                                    }
                                    if (material == "motes")
                                    {
                                        Console.WriteLine("Dragonwrath obtained!");
                                        keyMaterials["motes"] -= 250;

                                    }
                                    else if (material == "fragments")
                                    {
                                        Console.WriteLine("Valanyr obtained!");
                                        keyMaterials["fragments"] -= 250;
                                    }
                                    else if (material == "shards")
                                    {
                                        Console.WriteLine("Shadowmourne obtained!");
                                        keyMaterials["shards"] -= 250;
                                    }

                                    var sortedKeyMat = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
                                    foreach (var item in sortedKeyMat)
                                    {
                                        Console.WriteLine($"{item.Key}: {item.Value}");
                                    }

                                    var sortedJunks = junks.OrderBy(x => x.Key);
                                    foreach (var item in sortedJunks)
                                    {
                                        Console.WriteLine($"{item.Key}: {item.Value}");
                                    }
                                    return;
                                }
                            }
                        }
                        else
                        {
                            if (!junks.ContainsKey(material))
                            {
                                junks[material] = quantity;
                            }
                            else
                            {
                                junks[material] += quantity;
                            }

                        }
                    }
                }
            }
        }
    }
}
