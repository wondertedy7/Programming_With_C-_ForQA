
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

SortedDictionary<int, int> numberFrequency = new();

foreach (int number in nums)
{
	if (numberFrequency.ContainsKey(number))
	{
		numberFrequency[number] += 1;
	}
	else
	{
		numberFrequency.Add(number, 1);
		//numberFrequency[number] = 1;
	}
}
foreach (var pair in numberFrequency) // foreach (KeyValuePair<string, int> pair in numberFrequency)
{
	Console.WriteLine($"{pair.Key} -> {pair.Value}");
}

