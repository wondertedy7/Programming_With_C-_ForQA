
string word = Console.ReadLine();

Dictionary<char, int> occurrences = new();

string wordNoSpaces = word.Replace(" ", "");

foreach (var letter in wordNoSpaces)
{
	if (occurrences.ContainsKey(letter))
	{
		occurrences[letter]++;
	}
	else
	{
		occurrences.Add(letter, 1);
	}
}
foreach (var item in occurrences)
{
	Console.WriteLine($"{item.Key} -> {item.Value}");
}

