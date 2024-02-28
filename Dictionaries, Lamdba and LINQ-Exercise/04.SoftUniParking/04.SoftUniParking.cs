
int numOfCommands = int.Parse(Console.ReadLine());

Dictionary<string, string> registerUnregister = new();

for (int i = 0; i < numOfCommands; i++)
{
    List<string> inputs = Console.ReadLine().Split().ToList();
    string command = inputs[0];
    string username = inputs[1];

    if (command == "register")
    {
        string licencePlateNum = inputs[2];

        if (!registerUnregister.ContainsKey(username))
        {
            registerUnregister.Add(username, licencePlateNum);
            Console.WriteLine($"{username} registered {licencePlateNum} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {licencePlateNum}");
        }
    }
    else if (command == "unregister")
    {
        if (!registerUnregister.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            registerUnregister.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
    }
}
foreach (var item in registerUnregister)
{
    Console.WriteLine($"{item.Key} => {item.Value}");
}