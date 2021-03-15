using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            var followers = new Dictionary<string, Dictionary<string, int>>();
            string line;
            while ((line = Console.ReadLine()) != "Log out")
            {
                var cmd = line.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmd[0];
                if (action == "New follower")
                {
                    string user = cmd[1];
                    if (!followers.ContainsKey(user))
                    {
                        followers.Add(user, new Dictionary<string, int> { { "likes", 0 }, { "comments", 0 } });
                    }
                }
                else if (action == "Like")
                {
                    string user = cmd[1];
                    int count = int.Parse(cmd[2]);
                    if (!followers.ContainsKey(user))
                    {
                        followers.Add(user,new Dictionary<string, int>{ { "likes", count }, { "comments", 0 } });
                    }
                    else
                    {
                        followers[user]["likes"] += count;
                    }
                }
                else if (action == "Comment")
                {
                    string user = cmd[1];
                    if (!followers.ContainsKey(user))
                    {
                        followers.Add(user,new Dictionary<string, int> { { "likes", 0 } , {"comments", 1 } });
                        continue;
                    }
                    followers[user]["comments"] += 1;

                }
                else if (action == "Blocked")
                {
                    string user = cmd[1];

                    if (!followers.ContainsKey(user))
                    {
                        Console.WriteLine($"{user} doesn't exist.");
                        continue;
                    }
                    followers.Remove(user);
                }
            }

            Console.WriteLine($"{followers.Count} followers");
            foreach (var user in followers.OrderByDescending(x=>x.Value["likes"]).ThenBy(y=>y.Key))
            {
                Console.WriteLine($"{user.Key}: {user.Value["likes"] + user.Value["comments"]}");
            }
        }
    }
}
