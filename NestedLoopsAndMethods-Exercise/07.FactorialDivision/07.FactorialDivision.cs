
int num1 = int.Parse(Console.ReadLine());
int num2= int.Parse(Console.ReadLine());

double factorialNum1 = GetFactorialNum(num1);
double factorialNum2 = GetFactorialNum(num2);

double divided = factorialNum1 / factorialNum2;

Console.WriteLine(divided);

static double GetFactorialNum(double num)
{
	double product = 1;

	for (double i = num; i >= 1; i--)
	{
		product *= i;
	}
	return product;
}
