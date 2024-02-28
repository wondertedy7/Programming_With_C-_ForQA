
int number = int.Parse(Console.ReadLine());

Console.WriteLine(CheckPrimeNumber(number));

static bool CheckPrimeNumber (int number)
{
    int dividers = 0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            dividers++;
        }
    }
    return dividers == 2;
}