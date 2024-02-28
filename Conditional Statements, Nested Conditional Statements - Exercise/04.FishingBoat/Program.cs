namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //input

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            double boatRent = 0;

            //logic

            //if (season == "Spring")
            //{
            //    if (fishermanCount <= 6)
            //    {
            //        boatRent = 3000 * 0.9;
            //    }
            //    else if (fishermanCount >= 7 && fishermanCount <= 11)
            //    {
            //        boatRent = 3000 * 0.85;
            //    }
            //    else if (fishermanCount >= 12)
            //    {
            //        boatRent = 3000 * 0.75;
            //    }
            //}
            //else if (season == "Summer" || season == "Autumn")
            //{
            //    if (fishermanCount <= 6)
            //    {
            //        boatRent = 4200 * 0.9;
            //    }
            //    else if (fishermanCount >= 7 && fishermanCount <= 11)
            //    {
            //        boatRent = 4200 * 0.85;
            //    }
            //    else if (fishermanCount >= 12)
            //    {
            //        boatRent = 4200 * 0.75;
            //    }
            //}
            //else if (season == "Winter")
            //{
            //    if (fishermanCount <= 6)
            //    {
            //        boatRent = 2600 * 0.9;
            //    }
            //    else if (fishermanCount >= 7 && fishermanCount <= 11)
            //    {
            //        boatRent = 2600 * 0.85;
            //    }
            //    else if (fishermanCount >= 12)
            //    {
            //        boatRent = 2600 * 0.75;
            //    }
            //}
            //if (fishermanCount % 2 == 0 && season != "Autumn") 
            //{
            //    boatRent -= boatRent * 0.05;
            //}

            switch (season)
            {
                case "Spring":
                    boatRent = 3000;
                    break;
                case "Summer":   // когато имаме две или повече условия с еднакъв резултат при switch се изписват по този начин
                case "Autumn":   // case "дадения стейтмънт" следван от : и след това директно следващият case, и чак накрая се изписва общият резултат 
                    boatRent = 4200;
                    break;
                case "Winter":
                    boatRent = 2600;
                    break;
            }
            if (fishermanCount <= 6)
            {
                boatRent *= 0.9;
            }
            else if (fishermanCount >= 7 && fishermanCount <= 11)
            {
                boatRent *= 0.85;
            }
            else if (fishermanCount >= 12)
            {
                boatRent *= 0.75;
            }
            if (fishermanCount % 2 == 0 && season != "Autumn")
            {
                boatRent *= 0.95;
            }

            //output

            if (budget >= boatRent)
            {
                Console.WriteLine($"Yes! You have {budget - boatRent:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {boatRent - budget:f2} leva.");
            }
        }
    }
}