
using System.Text.RegularExpressions;

string pattern = @"\b(?<day>\d{2})(?<sep>[\/\-\.])(?<month>[A-Z][a-z]{2})\k<sep>(?<year>\d{4})\b"; // (?<sep>[\/\-\.]) група "сепаратор". Когато групите са ни именувани, вместо да ги извикваме по номер (\1, 2 ...) ги извикваме със запазената буква "к": (\k<name of the group>).

Regex regex = new Regex(pattern);

string input = Console.ReadLine();

MatchCollection matches = regex.Matches(input);

foreach (Match match in matches)
{
    Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
}
