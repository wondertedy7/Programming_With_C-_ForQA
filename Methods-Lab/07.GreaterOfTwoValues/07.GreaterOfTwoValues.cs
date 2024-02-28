
static string FindGreaterText(string text1, string text2)
{
    if (text1.CompareTo(text2) > 0)
    {
        return text1;
    }
    else
    {
        return text2;
    }
}

static char FindGreaterChar(char ch1, char ch2)
{
    if (ch1 > ch2)
    {
        return ch1;
    }
    else
    {
        return ch2;
    }
}

static int FindGreaterNum(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}


string type = Console.ReadLine();

if (type == "string")
{
    string text1 = Console.ReadLine();
    string text2 = Console.ReadLine();

    Console.WriteLine(FindGreaterText(text1, text2));
}
else if (type == "char")
{
    char ch1 = char.Parse(Console.ReadLine());
    char ch2 = char.Parse(Console.ReadLine());

    Console.WriteLine(FindGreaterChar(ch1, ch2));
}
else if (type == "int")
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine(FindGreaterNum(num1, num2));
}

