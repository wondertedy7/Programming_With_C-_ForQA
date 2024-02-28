
string word = "";

while ((word = Console.ReadLine()) != "end")
{
    string reversedWord = "";

    for (int i = word.Length - 1; i >= 0; i--)
    {
        reversedWord += word[i];
    }
    Console.WriteLine($"{word} = {reversedWord}");
}


//*******

/*while ((word = Console.ReadLine()) != "end")
{
    string originalWord = command;
    char[] reversedWord = command.ToCharArray();
    Array.Reverse(reversedWord);
    string reversed = string.Join("", reversedWord);

    Console.WriteLine($"{originalWord} = {reversed}");
}*/

//*******

/*while ((word = Console.ReadLine()) != "end")
{
    char[] wordAsCharArray = word.ToCharArray();
    Array.Reverse(wordAsCharArray);
    string reversed = string.Join("", wordAsCharArray);

    Console.WriteLine($"{word} = {reversed}");
}*/

//*******

/*while ((word = Console.ReadLine()) != "end")
{
    string reversed = string.Join("", word.ToCharArray().Reverse());

    Console.WriteLine($"{word} = {reversed}");
}*/