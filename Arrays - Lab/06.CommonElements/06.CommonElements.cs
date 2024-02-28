
int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int equals;

for (int index = 0; index < firstArray.Length; index++)
{
	for (int index1 = 0; index1 < secondArray.Length; index1++)
	{
        if (firstArray[index] == secondArray[index1])
        {
            equals = firstArray[index];
            Console.Write(equals + " ");
        }
    }

}
