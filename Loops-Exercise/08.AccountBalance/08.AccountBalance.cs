namespace _08.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            double balance = 0;

            while ((input = (Console.ReadLine())) != "End")
            {
                double money = double.Parse(input);

                if (money > 0)
                {
                    Console.WriteLine($"Increase: {money:f2} ");
                    balance += money;
                }
                else if (money < 0)
                {
                    Console.WriteLine($"Decrease: {Math.Abs(money):f2}");
                    balance += money;
                }
            }
            Console.WriteLine($"Balance: {balance:f2}");
        }
    }
}