
string[] words = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();

Dictionary<string, int> oddOccurrences = new();

foreach (var word in words)
{
	if (oddOccurrences.ContainsKey(word))
	{
		oddOccurrences[word] += 1;
	}
	else
	{
		oddOccurrences.Add(word, 1);
	}
}
foreach (var pair in oddOccurrences.Where(x => x.Value % 2 != 0))
{
	Console.Write($"{pair.Key} ");
}