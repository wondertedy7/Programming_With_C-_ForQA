
string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

foreach (string bannedWord in bannedWords)
{
	//string censoredWord = "".PadLeft(bannedWord.Length, '*');
	string censoredWord = new string('*', bannedWord.Length);

	if (text.Contains(bannedWord))
	{
		text = text.Replace(bannedWord, censoredWord);
	}
}
Console.WriteLine(text);