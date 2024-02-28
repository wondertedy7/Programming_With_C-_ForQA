
static int ReadNumber(int start, int end)
{
	int num = int.Parse(Console.ReadLine());

	if (num <= start || num >= end)
	{
		throw new ArgumentException();
	}

	return num;
}

List<int> numbers = new List<int>();

int previousNum = 1;

while (numbers.Count < 10)
{
	try
	{
        int number = ReadNumber(previousNum, 100);

        numbers.Add(number);
        previousNum = number;
    }
	catch (ArgumentException)
	{
		Console.WriteLine($"Your number is not in range {previousNum} - 100!");

    }
	catch (FormatException)
	{
		Console.WriteLine("Invalid Number!");
	}	
}
Console.WriteLine(string.Join(", ", numbers));
