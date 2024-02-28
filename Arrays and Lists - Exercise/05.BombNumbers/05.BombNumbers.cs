List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> bombAndPower = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int bombNumber = bombAndPower[0];
int power = bombAndPower[1];

if (numbers.Contains(bombNumber))
{
    while (numbers.Contains(bombNumber))
    {
        int index = numbers.IndexOf(bombNumber);
        int startindex = index - power;
        int removeCount = power * 2 + 1;
        if (startindex < 0)
        {
            removeCount += startindex; // if starIndex = -1 -> removeCount += -1 = removeCount - 1
            // removeCount -= Math.Abs(startIndex); 
            startindex = 0;
        }
        if (startindex + removeCount > numbers.Count)
        {
            removeCount = numbers.Count - startindex;
        }
        numbers.RemoveRange(startindex, removeCount);
    }    
}
int sum = numbers.Sum();

Console.WriteLine(sum);

