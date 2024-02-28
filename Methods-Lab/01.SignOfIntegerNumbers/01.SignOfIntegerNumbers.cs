
int num = int.Parse(Console.ReadLine());

PrintSignOfNum(num);

static void PrintSignOfNum(int num)
{
    if (num == 0)
    {
        Console.WriteLine($"The number {num} is zero.");
    }
    else if (num > 0)
    {
        Console.WriteLine($"The number {num} is positive.");
    }
    else
    {
        Console.WriteLine($"The number {num} is negative.");
    }
}