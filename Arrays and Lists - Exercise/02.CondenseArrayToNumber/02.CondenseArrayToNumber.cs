
using System;

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

while (numbers.Count > 1)
{
    List<int> condensed = new List<int>();
    for (int index = 0; index < numbers.Count - 1; index++)
    {
        condensed.Add(numbers[index] + numbers[index + 1]);        
    }
    numbers = condensed;
}
//Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(numbers[0]);
