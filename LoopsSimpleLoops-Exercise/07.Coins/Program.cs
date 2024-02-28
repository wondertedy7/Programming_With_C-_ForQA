namespace _07.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine()) * 100;

            int coinsCount = 0;

            while (change > 0)
            {
                if (change >= 200)
                {
                    change -= 200;
                    coinsCount++;
                }
                else if (change >= 100)
                {
                    change -= 100;
                    coinsCount++;
                }
                else if (change >= 50)
                {
                    change -= 50;
                    coinsCount++;
                }
                else if (change >= 20)
                {
                    change -= 20;
                    coinsCount++;
                }
                else if (change >= 10)
                {
                    change -= 10;
                    coinsCount++;
                }
                else if (change >= 5)
                {
                    change -= 5;
                    coinsCount++;
                }
                else if (change >= 2)
                {
                    change -= 2;
                    coinsCount++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    coinsCount++;
                }
                else
                {
                    change = 0;
                }
            }
            Console.WriteLine(coinsCount);
        }
    }
}