
using System.Text.RegularExpressions;

string pattern = @"\+359([\ \-])2\1\d{3}\1\d{4}\b"; // ([\ \-]) - група "разделител" търсим патерна да е с разделител или " " (празно място), или "-" (тире)Тук, тъй като са само два варианта, може да се изпише и така: (\ |\-), но когато са повече от два варианта, се пише с квадратните скоби и без "|"). Едно от двете! После навсякъде, където трябва да има разделител, изписваме само "\1", което е номера на групата.

Regex regex = new Regex(pattern);

string input = Console.ReadLine();

MatchCollection matches = regex.Matches(input);

Console.WriteLine(string.Join(", ", matches));