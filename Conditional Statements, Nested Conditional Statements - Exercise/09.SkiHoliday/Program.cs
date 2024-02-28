namespace _09.SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            int daysToStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string assessment = Console.ReadLine();

            double totalPrice = 0;

            //logic

            int nightsToStay = daysToStay - 1;

            if (daysToStay < 10)
            {
                if (typeOfRoom == "room for one person")
                {
                    totalPrice = nightsToStay * 118.00;
                }
                else if (typeOfRoom == "apartment")
                {
                    totalPrice = nightsToStay * 155.00 * 0.7;
                }
                else if (typeOfRoom == "president apartment")
                {
                    totalPrice = nightsToStay * 235.00 * 0.9;
                }
            }
            else if (daysToStay >= 10 && daysToStay <= 15)
            {
                if (typeOfRoom == "room for one person")
                {
                    totalPrice = nightsToStay * 118.00;
                }
                else if (typeOfRoom == "apartment")
                {
                    totalPrice = nightsToStay * 155.00 * 0.65;
                }
                else if (typeOfRoom == "president apartment")
                {
                    totalPrice = nightsToStay * 235.00 * 0.85;
                }
            }
            else if (daysToStay > 15)
            {
                if (typeOfRoom == "room for one person")
                {
                    totalPrice = nightsToStay * 118.00;
                }
                else if (typeOfRoom == "apartment")
                {
                    totalPrice = nightsToStay * 155.00 * 0.5;
                }
                else if (typeOfRoom == "president apartment")
                {
                    totalPrice = nightsToStay * 235.00 * 0.8;
                }
            }

            //output

            if (assessment == "positive")
            {
                Console.WriteLine($"{totalPrice *= 1.25:f2}");
            }
            else if (assessment == "negative")
            {
                Console.WriteLine($"{totalPrice *= 0.9:f2}");
            }

        }
    }
}