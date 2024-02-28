static int MathPower(int baseNum, int power, int result)
{
    for (int i = 1; i <= power; i++)
    {
        result *= baseNum;
    }

    return result;
}

int baseNum = int.Parse(Console.ReadLine()); 
int power = int.Parse(Console.ReadLine());

int result = 1;

result = MathPower(baseNum, power, result);


Console.WriteLine(result);