

string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double price = CalculateOrdersPrice(product, quantity);

Console.WriteLine($"{price:f2}");

static double CalculateOrdersPrice(string product, int quantity)
{
    double price = 1;
    if (product == "coffee")
    {
        price = quantity * 1.5;
    }
    else if (product == "water")
    {
        price = quantity * 1;
    }
    else if (product == "coke")
    {
        price = quantity * 1.4;
    }
    else if (product == "snacks")
    {
        price = quantity * 2;
    }

    return price;
}