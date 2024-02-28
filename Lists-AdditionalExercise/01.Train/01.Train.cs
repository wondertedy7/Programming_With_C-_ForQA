
List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int wagonCapacity = int.Parse(Console.ReadLine());

string input;

while ((input = Console.ReadLine()) != "end")
{
	if (input.StartsWith("Add"))
	{
		int wagonToAdd = int.Parse(input.Split(" ")[1]);
		wagons.Add(wagonToAdd);
	}
	else
	{
        int passengers = int.Parse(input);

		for (int i = 0; i < wagons.Count; i++)
		{
			if ((passengers + wagons[i]) <= wagonCapacity)
            {
                wagons.Insert(i, passengers + wagons[i]);
                wagons.Remove(wagons[i + 1]);
                break;
			}
		}
    }
}
Console.WriteLine(string.Join(" ", wagons));