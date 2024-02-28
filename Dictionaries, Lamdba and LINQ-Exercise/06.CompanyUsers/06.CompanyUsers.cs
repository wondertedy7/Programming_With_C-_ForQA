
string command = "";

Dictionary<string, List<string>> companyEmployees = new();

while ((command = Console.ReadLine()) != "End")
{
    List<string> commands = command.Split(" -> ").ToList();
    string companyName = commands[0];
    string employeeID = commands[1];

    if (!companyEmployees.ContainsKey(companyName))
    {
        companyEmployees.Add(companyName, new List<string>());
        //companyEmployees.Add(companyName, new () { employeeID });
    }
    
    if (!companyEmployees[companyName].Contains(employeeID))
    {
        companyEmployees[companyName].Add(employeeID);
    }
}
foreach (var item in companyEmployees)
{
    Console.WriteLine($"{item.Key} \n -- {string.Join("\n -- ", item.Value)}");
}
