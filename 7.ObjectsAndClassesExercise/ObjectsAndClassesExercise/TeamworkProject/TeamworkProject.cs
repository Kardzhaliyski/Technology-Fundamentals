using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProject
{
    class TeamworkProject
    {
        static void Main(string[] args)
        {
            int teamsToRegister = int.Parse(Console.ReadLine());
            var allTeams = new Dictionary<string,Team>();

            for (int i = 0; i < teamsToRegister; i++)
            {
                var tokens = Console.ReadLine()
                    .Split('-',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string creator = tokens[0];
                string teamName = tokens[1];

                if (allTeams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (IsCreator(allTeams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                allTeams[teamName] = new Team(teamName,creator);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                string[] tokens = input
                    .Split("->",StringSplitOptions.RemoveEmptyEntries);
                string player = tokens[0];
                string teamName = tokens[1];


                if (allTeams.ContainsKey(teamName) == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (InAnotherTeam(allTeams, player))
                {
                    Console.WriteLine($"Member {player} cannot join team {teamName}!");
                    continue;
                }

                allTeams[teamName].MembersList.Add(player);
            }

            var teamsToDisband = allTeams
                .Where(x => x.Value.MembersList.Count == 0)
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key , x=> x.Value);

            allTeams = allTeams
                .Where(x => x.Value.MembersList.Count > 0)
                .OrderByDescending(x => x.Value.MembersList.Count)
                .ThenBy(x => x.Value.Name)
                .ToDictionary(x => x.Key, x => x.Value);

            PrintTeams(allTeams);
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.Key);
            }


        }

        public static void PrintTeams(Dictionary<string, Team> teams)
        {
            foreach (var team in teams)
            {
                Console.WriteLine(team.Key);
                Console.WriteLine($"- {team.Value.Creator}");
                team.Value.MembersList = team.Value.MembersList.OrderBy(x => x).ToList();
                foreach (var member in team.Value.MembersList)
                {
                    Console.WriteLine($"-- {member}");
                }

            }
        }

        public static bool IsCreator(Dictionary<string,Team> teams,string creator)
        {
            foreach (var team in teams)
            {
                if (team.Value.Creator == creator)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool InAnotherTeam(Dictionary<string, Team> teams, string player)
        {
            foreach (var team in teams)
            {
                if (team.Value.Creator == player)
                {
                    return true;
                }

                if (team.Value.MembersList.Contains(player))
                {
                    return true;
                }
            }

            return false;
        }

    }

    class Team
    {
        public Team(string name,string creator)
        {
            Name = name;
            Creator = creator;
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> MembersList { get; set; } = new List<string>();



    }
}
