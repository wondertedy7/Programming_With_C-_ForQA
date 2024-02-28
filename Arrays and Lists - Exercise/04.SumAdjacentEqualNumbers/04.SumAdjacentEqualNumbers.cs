
List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

for (int index = 0; index < numbers.Count - 1; index++)
{
    int num1 = numbers[index];
    int num2 = numbers[index + 1];

	if (num1 == num2)
	{
        numbers[index] = num1 + num2;
        numbers.RemoveAt(index + 1);
        index = -1;
    }
}
Console.WriteLine(string.Join(" ", numbers));  