
static void PrintLine(int start, int end)
{
	for (int  i = start; i <= end; i++)
	{
		Console.Write(i + " ");
	}
	Console.WriteLine();
}


static void PrintTriangle(int num)
{
    for (int thisLine = 1; thisLine <= num; thisLine++)
    {
        PrintLine(1, thisLine);
    }
	for (int thisLine = num - 1; thisLine >= 1 ; thisLine--)
	{
		PrintLine(1, thisLine);
	}
}

int num = int.Parse(Console.ReadLine());

PrintTriangle(num);


