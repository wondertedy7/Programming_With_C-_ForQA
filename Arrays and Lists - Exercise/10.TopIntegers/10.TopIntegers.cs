
List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> topIntegers = new List<int>();

for (int i = 0; i < numbers.Count; i++)
{
    bool isTopInteger = true;

	for (int n = i + 1; n < numbers.Count; n++)
	{

        if (numbers[i] <= numbers[n])
		{
            isTopInteger = false;
            break;
        }
    }
    if (isTopInteger)
    {
        topIntegers.Add(numbers[i]);
    }

}
Console.WriteLine(string.Join(" ", topIntegers));