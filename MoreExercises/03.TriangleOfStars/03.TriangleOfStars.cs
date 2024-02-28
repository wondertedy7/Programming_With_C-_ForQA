
int size = int.Parse(Console.ReadLine());

//for (int i = 1; i <= size; i++)
//{
//	for (int j = 1; j <= i; j++)
//	{
//		Console.Write("*");
//	}
//	Console.WriteLine();
//}

//*****

for (int i = 1; i <= size; i++)
{
	string bufferSpace = new string(' ', size - i); // ако искаме триъгълникът да е обърнат
	Console.Write(bufferSpace);


	string line = new string('*', i);
	Console.WriteLine(line);
}