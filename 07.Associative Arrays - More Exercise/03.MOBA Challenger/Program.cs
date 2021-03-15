using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            var players = new Dictionary<string, Dictionary<string, int>>();

            while ((line = Console.ReadLine()) != "Season end")
            {
                if (line.Contains("->"))
                {
                    var cmd = line.Split(" -> ");
                    string player = cmd[0];
                    string position = cmd[1];
                    int skill = int.Parse(cmd[2]);
                    if (!players.ContainsKey(player))
                    {
                        players[player] = new Dictionary<string, int> { { position, skill } };
                    }
                    if (!players[player].ContainsKey(position))
                    {
                        players[player][position] = skill;
                    }
                    if (players[player][position]<=skill)
                    {
                        players[player][position] = skill;
                    }

                }
                else if(line.Contains(" vs "))
                {
                    var tokens = line.Split(" vs ");
                    string player1 = tokens[0];
                    string player2 = tokens[1];

                    if (players.ContainsKey(player1) && players.ContainsKey(player2) && PlayersCommon(players, player1, player2))
                    {
                        if (players[player1].Values.Sum() > players[player2].Values.Sum())
                        {
                            players.Remove(player2);
                        }
                        else
                        {
                            players.Remove(player1);
                        }
                    }

                }

            }
            PrintResult(players);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int>> players)
        {
            foreach (var player in players.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                
                foreach (var item in player.Value.OrderByDescending(x=>x.Value).ThenBy(a=>a.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
                

            }
        }

        private static bool PlayersCommon(Dictionary<string, Dictionary<string, int>> input, string player1, string player2)
        {
            foreach (KeyValuePair<string, int> first in input[player1])
            {
                foreach (KeyValuePair<string, int> second in input[player2])
                {
                    if (first.Key == second.Key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
