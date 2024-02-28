namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = peopleCount * 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = peopleCount * 9.8;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = peopleCount * 10.46;
                }
                if (peopleCount >= 30)
                {
                    price *= 0.85;
                }
            }
            else if (groupType == "Business")
            {
                if (peopleCount >= 100)
                {
                    peopleCount -= 10;
                }
                if (dayOfWeek == "Friday")
                {
                    price = peopleCount * 10.9;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = peopleCount * 15.6;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = peopleCount * 16;
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = peopleCount * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = peopleCount * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = peopleCount * 22.5;
                }
                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    price *= 0.95;
                }
            }
                Console.WriteLine($"Total price: {price:f2}");
        }
    }
}