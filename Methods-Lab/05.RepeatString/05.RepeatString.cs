static string RepeatText(string text, int count)
{
    string output = string.Empty;
	for (int i = 0; i < count; i++)
	{
		output += text;
	}
	return output;
}

string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

string result = RepeatText(text, count);

Console.WriteLine(result);