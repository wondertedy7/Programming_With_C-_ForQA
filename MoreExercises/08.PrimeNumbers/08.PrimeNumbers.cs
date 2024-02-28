
int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
	int divisors = 0;

	for (int j = 1; j <= i; j++)
	{
        if (i % j == 0)
		{
			divisors++;
		}
	}
    if (divisors == 2)
    {
        Console.Write($"{i} ");
    }
}