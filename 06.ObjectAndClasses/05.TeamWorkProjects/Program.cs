using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamWorkProjects
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<Team> allTeams = new List<Team>();
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split("-");
                string creator = tokens[0];
                string name = tokens[1];

                Team existingTeam = allTeams.Find(x => x.Name == name);
                Team existingCreator = allTeams.Find(x => x.Creator == creator);

                if (existingTeam != null)
                {
                    Console.WriteLine($"Team {name} was already created!");
                    continue;
                }
                if (existingCreator != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                Team myTeam = new Team(creator, name);
                allTeams.Add(myTeam);
                Console.WriteLine($"Team {name} has been created by {creator}!");
            }
            string line = Console.ReadLine();
            while (line  != "end of assignment")
            {
                string[] inputSplitted = line.Split("->");
                string member = inputSplitted[0];
                string name = inputSplitted[1];
                
                Team existingTeam = allTeams.Find(x => x.Name == name);
                Team existingTeamMember = allTeams.Find(x => x.Members.Contains(member) || x.Creator==member);
                if (existingTeam==null)
                {
                    Console.WriteLine($"Team {name} does not exist!");
                    line =Console.ReadLine();
                    continue;
                }
                if (existingTeamMember!=null)
                {
                    Console.WriteLine($"Member {member} cannot join team {name}!");
                    line =Console.ReadLine();
                    continue;
                }
                existingTeam.Members.Add(member);
                line =Console.ReadLine();
            }

            List<string> allDisbandTeams = allTeams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name).Select(a=>a.Name).ToList();
            allTeams.RemoveAll(x => x.Members.Count == 0);
            List<Team> sortedMembers = allTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();
            foreach (Team t in sortedMembers)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine("Teams to disband:");
            foreach (string t in allDisbandTeams)
            {
                Console.WriteLine(t.ToString());
            }
            
        }

        class Team
        {
            public Team(string creator, string teamName)
            {
                this.Creator = creator;
                this.Name = teamName;
                this.Members = new List<string>();
            }
            public string Creator { get; set; }
            public string Name { get; set; }
            public List<string> Members { get; 
                set; }
            
            public override string ToString()
            {
                List<string> sortedMembers = this.Members.OrderBy(a => a).ToList();
                string output = $"{this.Name}\n";
                output += $"- {this.Creator}\n";
                for (int i = 0; i < sortedMembers.Count; i++)
                {
                    output += $"-- {sortedMembers[i]}\n";
                }
                return output.Trim();
            }
        }
    }
}
