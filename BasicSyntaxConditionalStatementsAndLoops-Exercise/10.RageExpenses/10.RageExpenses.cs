namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalExpenses;

            int totalheadsetTrashed = lostGamesCount / 2;
            int totalmouseTrashed = lostGamesCount / 3;
            int totalKeyboardTrashed = lostGamesCount / 6;
            int totalDisplayTrashed = totalKeyboardTrashed / 2;

            totalExpenses = totalheadsetTrashed * headsetPrice
                + totalmouseTrashed * mousePrice
                + totalKeyboardTrashed * keyboardPrice
                + totalDisplayTrashed * displayPrice;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");

        }
    }
}