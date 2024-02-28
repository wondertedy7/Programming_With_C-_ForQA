List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

//int sum = 0;
int n = numbers.Count;

//for (int i = 1; i <= n / 2; i++)
//{
//    sum = numbers[i] + numbers[n - i - 1];
//    Console.Write(sum + " ");
//}
//if (n % 2 != 0)
//{
//    Console.Write(numbers[n / 2]);
//}

// *******

List<int> output = new List<int>();

for (int i = 0; i < n / 2; i++)
{
    int sum1 = numbers[i] + numbers[n - i - 1];
    output.Add(sum1);
}
if (n % 2 != 0)
{
    int num = numbers[n / 2];
    output.Add(num);
}
Console.WriteLine(string.Join(" ", output));