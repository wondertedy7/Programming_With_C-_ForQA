
string text = Console.ReadLine();

Console.WriteLine(GetVowelsCount(text));

// Vowels: A, a, E, e, I, i, U, u, O, o 
static int GetVowelsCount (string text)
{
    int vowelsCount = 0;

	for (int i = 0; i <= text.Length - 1; i++)
	{
		char symbol = text[i];

		if (symbol == 'A' || symbol == 'a' || symbol == 'E' || symbol == 'e' 
			|| symbol == 'I' || symbol == 'i' || symbol == 'U' || symbol == 'u' 
			|| symbol == 'O' || symbol == 'o')
		{
			vowelsCount++;
		}
	}
	return vowelsCount;
}