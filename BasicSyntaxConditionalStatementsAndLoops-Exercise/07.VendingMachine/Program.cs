namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double money = 0;
            string purchase = "";

            while ((input = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(input);

                if (coins != 0.1 && coins != 0.2 && coins != 0.5 
                    && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }
                money += coins;
            }

            string product;
            while ((product = Console.ReadLine()) != "End")
            {
                if (product == "Nuts")
                {
                    if (money >= 2)
                    {
                        purchase = "nuts";
                        Console.WriteLine($"Purchased {purchase}");
                        money -= 2;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (money >= 0.7)
                    {
                        purchase = "water";
                        Console.WriteLine($"Purchased {purchase}");
                        money -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (money >= 1.5)
                    {
                        purchase = "crisps";
                        Console.WriteLine($"Purchased {purchase}");
                        money -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (money >= 0.8)
                    {
                        purchase = "soda";
                        Console.WriteLine($"Purchased {purchase}");
                        money -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (money >= 1)
                    {
                        purchase = "coke";
                        Console.WriteLine($"Purchased {purchase}");
                        money -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }
            }
            Console.WriteLine($"Change: {money:f2}");

        }
    }
}