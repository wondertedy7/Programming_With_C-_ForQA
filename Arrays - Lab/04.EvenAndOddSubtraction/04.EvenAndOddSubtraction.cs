
int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int sumEven = 0;
int sumOdd = 0;

foreach (int n in nums)
{
	if (n % 2 == 0)
	{
		sumEven += n;
	}
	else
	{
		sumOdd += n;
	}
}
Console.WriteLine(sumEven - sumOdd);
