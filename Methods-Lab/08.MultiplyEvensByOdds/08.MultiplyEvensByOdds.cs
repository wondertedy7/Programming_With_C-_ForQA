
static int GetMultipleOfEvenAndOdds(int number)
{
    int sumOfEven = GetSumOfEvenDigits(number);
    int sumOfOdds = GetSumOfOddDigits(number);

    int result = sumOfEven * sumOfOdds;
    return result;
}

static int GetSumOfOddDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number = number / 10;

        if (digit % 2 != 0)
        {
            sum += digit;
        }
    }
    return sum;
}

static int GetSumOfEvenDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number = number / 10;

        if (digit % 2 == 0)
        {
            sum += digit;
        }
    }
    return sum;
}

int number = int.Parse(Console.ReadLine());

number = Math.Abs(number);

int output = GetMultipleOfEvenAndOdds(number);

Console.WriteLine(output);