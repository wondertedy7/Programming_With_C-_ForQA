
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;

int countOfTeams = int.Parse(Console.ReadLine());

Dictionary<string, Team> teams = new Dictionary<string, Team>();

string teamName;
string creator;

for (int i = 0; i < countOfTeams; i++)
{
    string[] createATeam = Console.ReadLine().Split("-");
    creator = createATeam[0];
    teamName = createATeam[1];

    Team currentTeam = new Team(teamName, creator);

    if (teams.Any(t => t.Value.Creator == creator))
    {
        Console.WriteLine($"{creator} cannot create another team!");
    }
    else
    {
        if (teams.ContainsKey(teamName))
        {
            Console.WriteLine($"Team {teamName} was already created!");
        }
        else
        {
            teams.Add(teamName, currentTeam);
            Console.WriteLine($"Team {teamName} has been created by {creator}!");
        }
    }

}
    string command = "";

while ((command = Console.ReadLine()) != "end of assignment")
{
    string[] joinTeam = command.Split("->");
    string member = joinTeam[0];
    teamName = joinTeam[1];
    
    //Team currentMember = new Team(teamName, member);

    if (!teams.ContainsKey(teamName))
    {
        Console.WriteLine($"Team {teamName} does not exist!");
    }
    else if (teams.Any(t => t.Value.Members.Contains(member)) || teams.Values.Any(t => t.Creator == member))
    {
        Console.WriteLine($"Member {member} cannot join team {teamName}!");
    }
    else 
    {
        teams[teamName].Members.Add(member);
    }
    
}    

foreach (var team in teams.Where(team => team.Value.Members.Count > 0)
                            .OrderByDescending(team => team.Value.Members.Count)
                            .ThenBy(team => team.Key))
{
    Console.WriteLine(team.Key);
    Console.WriteLine($"- {team.Value.Creator}");

    foreach (string member in team.Value.Members.OrderBy(m => m))
    {
        Console.WriteLine($"-- {member}");
    }
}

Console.WriteLine("Teams to disband: ");
foreach (var team in teams.Where(team => team.Value.Members.Count == 0)
                            .OrderByDescending(team => team.Value.Members.Count)
                            .ThenBy(team => team.Key))
{
    Console.WriteLine(team.Key);
}


public class Team
{
    public string TeamName { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }

    public Team(string teamName, string creator)
    {
        this.TeamName = teamName;
        this.Creator = creator;
        this.Members = new List<string>();

    }
}