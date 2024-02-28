
using System.Text;

string[] words = Console.ReadLine().Split();

//string output = "";

StringBuilder output = new();

for (int i = 0; i < words.Length; i++)
{
    string currentWord = words[i];
	for (int j = 0; j < currentWord.Length; j++)
	{
		//output += currentWord;
		output.Append(currentWord);
	}
}
Console.WriteLine(output);

//*******

/*string words = string.Concat(Console.ReadLine().Split().Select(x => string.Concat(Enumerable.Repeat(x, x.Length))));

Console.WriteLine(words);*/ // цалото решение на един ред 