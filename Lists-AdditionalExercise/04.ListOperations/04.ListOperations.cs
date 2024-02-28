
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = "";

while ((command = Console.ReadLine()) != "End")
{
    List<string> operations = command.Split().ToList();
    int number = int.Parse(operations[1]);
    int index = int.Parse(operations[2]);
    int count = 0;

	if (operations.Contains("Add"))
	{
		numbers.Add(number);
	}
	else if (operations.Contains("Insert"))
	{		
		if (index > numbers.Count - 1)
		{
            Console.WriteLine("Invalid index");
            continue;
        }
		numbers.Insert(index, number);
    }
	else if (operations.Contains("Remove"))
	{
		index = int.Parse(operations[1]);
		if (index > numbers.Count - 1)
		{
			Console.WriteLine("Invalid index");
			continue;
		}
		numbers.Remove(numbers[index]);
	}
    else if (operations.Contains("Shift") && operations.Contains("right"))
    {
		count = int.Parse(operations[2]);
		for (int i = 0; i < count; i++)
		{
            int lastElement = numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1); 
            numbers.Insert(0, lastElement);
        }
    }
    else if (operations.Contains("Shift") && operations.Contains("left"))
    {
        count = int.Parse(operations[2]);
        for (int i = 0; i < count; i++)
		{
            int firstElement = numbers[0];
            numbers.RemoveAt(0);
            numbers.Add(firstElement);
        }

    }
}
Console.WriteLine(string.Join(" ", numbers));