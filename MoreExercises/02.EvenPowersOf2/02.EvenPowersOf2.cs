﻿
int n = int.Parse(Console.ReadLine());

for (int i = 0; i <= n; i++)  // --> i += 2 - спестяваме проверката if (i % 2 == 0)
{
	if (i % 2 == 0)
	{
		Console.WriteLine(Math.Pow(2, i));
	}
}
