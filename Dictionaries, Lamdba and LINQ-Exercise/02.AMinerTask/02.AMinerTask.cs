
string input = "";

Dictionary<string, int> resourseQuantities = new();

while ((input = Console.ReadLine()) != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

	if (resourseQuantities.ContainsKey(input))
	{
		resourseQuantities[input] += quantity;
	}
	else
	{
        resourseQuantities.Add(input, quantity);
    }
}
foreach (var item in resourseQuantities)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}