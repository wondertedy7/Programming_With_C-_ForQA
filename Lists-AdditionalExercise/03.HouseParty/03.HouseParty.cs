
int numberOfCommands = int.Parse(Console.ReadLine());

List<string> guestList = new List<string>();

for (int i = 1; i <= numberOfCommands; i++)
{
	List<string> fullCommand = Console.ReadLine().Split().ToList();
	string name = fullCommand[0];

    if (fullCommand.Contains("is") && fullCommand.Contains("not"))
    {
        if (guestList.Contains(name))
        {
            guestList.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
    else if (fullCommand.Contains("is") && fullCommand.Contains("going!"))
	{
		if (guestList.Contains(name))
		{
			Console.WriteLine($"{name} is already in the list!");
		}
		else
		{
            guestList.Add(name);
        }
    }

}
Console.WriteLine(string.Join("\n", guestList));
