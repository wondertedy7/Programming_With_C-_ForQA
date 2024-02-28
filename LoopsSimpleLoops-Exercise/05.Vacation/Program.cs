namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int spendingCount = 0;

            //logic

            while (availableMoney < neededMoney && spendingCount <5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCount ++;

                if (command == "spend")
                {
                    availableMoney -= money;
                    spendingCount ++;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
                else if (command == "save")
                {
                    availableMoney += money;
                    spendingCount = 0;
                }

            }
            if (spendingCount == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCount}");
            }
            else if (availableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}