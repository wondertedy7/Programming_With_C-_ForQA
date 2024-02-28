namespace P12.CoffeeShopWithChecks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string extra = Console.ReadLine();

            double price;

            if (drink == "coffee")
            {
                price = 1;

                if (extra == "sugar")
                {
                    price += 0.40;
                    Console.WriteLine($"Final price: ${price:f2}");
                }
                else if (extra == "no")
                {
                    Console.WriteLine($"Final price: ${price:f2}");
                }
                else
                {
                    Console.WriteLine("Unknown extra");
                }
            }
            else if (drink == "tea")
            {
                price = 0.60;

                if (extra == "sugar")
                {
                    price += 0.40;
                    Console.WriteLine($"Final price: ${price:f2}");
                }
                else if (extra == "no")
                {
                    Console.WriteLine($"Final price: ${price:f2}");
                }
                else
                {
                    Console.WriteLine("Unknown extra");
                }
            }
            else
            {
                Console.WriteLine("Unknown drink");
            }
        }
    }
}