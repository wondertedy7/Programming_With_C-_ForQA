
string[] words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

//string[] result = words.Where(x => x.Length % 2 == 0).ToArray();

foreach (var word in words) // words -> result
{
    Console.WriteLine(word);
}

