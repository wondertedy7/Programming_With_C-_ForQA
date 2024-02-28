
  double num1 = double.Parse(Console.ReadLine());
  double num2 = double.Parse(Console.ReadLine());
  double num3 = double.Parse(Console.ReadLine());

double biggest = 0;
double second = 0;
double smallest = 0;

if (num1 > num2 && num1 > num3)
{
    biggest = num1;

	if (num2 > num3)
	{
		second = num2;
		smallest = num3;
	}
	else
	{
		second = num3;
		smallest = num2;
	}
}
else if (num2 > num1 && num2 > num3)
{
	biggest = num2;

	if (num1 > num3)
	{
		second = num1;
		smallest = num3;
	}
	else
	{
        second = num3;
        smallest = num1;
    }
}
else if (num3 > num2 && num3 > num1)
{
	biggest = num3;

	if (num2 > num1)
	{
		second = num2;
		smallest = num1;
	}
	else
	{
        second = num1;
        smallest = num2;
    }
}

Console.WriteLine(biggest);
Console.WriteLine(second);
Console.WriteLine(smallest);


