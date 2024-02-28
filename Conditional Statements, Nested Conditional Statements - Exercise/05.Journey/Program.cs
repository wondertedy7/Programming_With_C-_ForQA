namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //logic

            string destination = "";
            string holidayType = "";
            double moneySpent = 0;

            if (budget >= 10 && budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    holidayType = "Camp";
                    moneySpent = budget * 0.3;
                }
                else if (season == "winter")
                {
                    holidayType = "Hotel";
                    moneySpent = budget * 0.7;
                }

            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    holidayType = "Camp";
                    moneySpent = budget * 0.4;
                }
                else if (season == "winter")
                {
                    holidayType = "Hotel";
                    moneySpent = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                holidayType = "Hotel";
                moneySpent = budget * 0.9;
            }

            //output

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {moneySpent:f2}");
        }
    }
}