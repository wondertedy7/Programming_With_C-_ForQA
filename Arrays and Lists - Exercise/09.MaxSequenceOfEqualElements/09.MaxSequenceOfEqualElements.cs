
List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int longestStart = 0;
int longestCount = 1;
int currentStart = 0;
int currentCount = 1;

List<int> equals = new List<int>();

for (int i = 1; i < numbers.Count; i++)
{
	if (numbers[i] == numbers[i - 1])
	{
		currentCount++;
		if (currentCount > longestCount)
		{
			longestCount = currentCount;
			longestStart = currentStart;
		}
	}
	else
	{
		currentStart = i;
		currentCount = 1;
	}
	equals = numbers.GetRange(longestStart, longestCount); 
}
Console.WriteLine(string.Join(" ", equals));
