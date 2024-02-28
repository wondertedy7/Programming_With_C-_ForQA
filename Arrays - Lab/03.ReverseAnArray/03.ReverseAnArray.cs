
int num = int.Parse(Console.ReadLine());

int[] numbers = new int[num];

for (int index = 0 ; index < numbers.Length; index++)
{
    numbers[index] = int.Parse(Console.ReadLine());
}

for (int index = numbers.Length - 1; index >= 0; index--)
{
    Console.Write(numbers[index] + " ");
}
