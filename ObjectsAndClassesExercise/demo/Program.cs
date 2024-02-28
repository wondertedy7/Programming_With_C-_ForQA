using System.Text;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());

            Dictionary<string, Team> teams = new();


            for (int i = 1; i <= teamCount; i++)
            {
                string[] teamData = Console.ReadLine().Split("-").ToArray();
                string creator = teamData[0];
                string teamToCreate = teamData[1];

                // && teams.Any(t => t.Value.Creator != creator
                if (!teams.ContainsKey(teamToCreate) && !teams.Any(t => t.Value.Creator == creator))
                {
                    Team newTeam = new Team(teamToCreate, creator);
                    teams.Add(teamToCreate, newTeam);
                    Console.WriteLine($"Team {teamToCreate} has been created by {creator}!");

                }
                else if (teams.Any(t => t.Value.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");

                }
                else
                {
                    Console.WriteLine($"Team {teamToCreate} was already created!");
                }

            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string userToJoin = command.Split("->")[0];
                string teamToJoin = command.Split("->")[1];

                if (!teams.ContainsKey(teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Any(t => t.Value.TeamMembers.Contains(userToJoin)) || teams[teamToJoin].Creator == userToJoin)
                {
                    Console.WriteLine($"Member {userToJoin} cannot join team {teamToJoin}!");

                }
                else
                {
                    teams[teamToJoin].TeamMembers.Add(userToJoin);

                }
                command = Console.ReadLine();
            }


            foreach (KeyValuePair<string, Team> kvp in teams.OrderByDescending(t => t.Value.TeamMembers.Count()).ThenBy(t => t.Key))
            {
                if (kvp.Value.TeamMembers.Count() > 0)
                {
                    Console.WriteLine(kvp.Value.ToString());
                }

            }
            Console.WriteLine("Teams to disband:");



            foreach (KeyValuePair<string, Team> kvp in teams.OrderBy(t => t.Key))
            {
                if (kvp.Value.TeamMembers.Count() == 0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
    internal class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }

        public List<string> TeamMembers { get; set; }

        public Team(string Name, string Creator)
        {
            this.Name = Name;
            this.Creator = Creator;
            this.TeamMembers = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Name).Append(Environment.NewLine).Append($"- {this.Creator}");
            this.TeamMembers.Sort();
            foreach (string member in this.TeamMembers)
            {
                sb.Append(Environment.NewLine).Append($"-- {member}");
            }

            return sb.ToString().Trim();
        }
    }
}