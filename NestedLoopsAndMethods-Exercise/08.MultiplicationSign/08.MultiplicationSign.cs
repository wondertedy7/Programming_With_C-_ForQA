
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

PrintSign(num1, num2, num3);
static void PrintSign (int n1, int n2, int n3)
{
	if (n1 == 0 || n2 == 0 || n3 == 0)
	{
		Console.WriteLine("zero");
	}
	else if (n1 > 0 && n2 > 0 && n3 > 0)
	{
		Console.WriteLine("positive");
	}
	else if (n1 < 0 && n2 < 0 && n3 > 0)
	{
        Console.WriteLine("positive");
    }
	else if (n1 > 0 && n2 < 0 && n3 <0)
	{
        Console.WriteLine("positive");
    }
	else if (n1 < 0 && n2 > 0 && n3 <0)
	{
        Console.WriteLine("positive");
    }
	else
	{
		Console.WriteLine("negative");
	}
}