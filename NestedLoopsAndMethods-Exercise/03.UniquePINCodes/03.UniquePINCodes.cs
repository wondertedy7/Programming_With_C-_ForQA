
int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for (int a = 2; a <= max1; a += 2)
{
	for (int b = 2; b <= max2; b++)
	{
		for (int c = 2; c <= max3; c += 2)
		{
			if (b == 2 || b == 3 || b == 5 || b == 7)
			{
                Console.WriteLine($"{a}{b}{c}");
            }
        }
	}
}
