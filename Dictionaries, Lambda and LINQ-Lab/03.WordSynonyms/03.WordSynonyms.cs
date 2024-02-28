
int numberOfWords = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> synonymusWords = new();

for (int i = 0; i < numberOfWords; i++)
{
    string word = Console.ReadLine();
    string synonymus = Console.ReadLine();

    if (synonymusWords.ContainsKey(word))
    {
        synonymusWords[word].Add(synonymus);
    }
    else
    {
        synonymusWords.Add(word, new List<string> { synonymus });
    }
}
foreach (var pair in synonymusWords)
{
    Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
}

