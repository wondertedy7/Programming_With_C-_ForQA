
int floorsCount = int.Parse(Console.ReadLine());
int estateCount = int.Parse(Console.ReadLine());

for (int i = floorsCount; i >= 1; i--)
{
	for (int j = 0; j < estateCount; j++)
	{
		if (i == floorsCount)
		{
			Console.Write($"L{i}{j} ");
		}
		else if (i % 2 == 0)
		{
			Console.Write($"O{i}{j} ");
		}
		else
		{
			Console.Write($"A{i}{j} ");
		}

	}
	Console.WriteLine();
}