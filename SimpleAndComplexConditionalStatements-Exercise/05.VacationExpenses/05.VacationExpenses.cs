using System.Timers;

namespace _05.VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accommodType = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());

            double discount = 0;
            double totalPrice = 0;
            if (season == "Spring")
            {
                discount = 0.8;

                if (accommodType == "Hotel")
                {
                    totalPrice = daysCount * 30 * discount;
                }
                else if (accommodType == "Camping")
                {
                    totalPrice = daysCount * 10 * discount;
                }
            }
            else if (season == "Summer")
            {

                if (accommodType == "Hotel")
                {
                    totalPrice = daysCount * 50;
                }
                else if (accommodType == "Camping")
                {
                    totalPrice = daysCount * 30;
                }
            }
            else if (season == "Autumn")
            {
                discount = 0.7;

                if (accommodType == "Hotel")
                {
                    totalPrice = daysCount * 20 * discount;
                }
                else if (accommodType == "Camping")
                {
                    totalPrice = daysCount * 15 * discount;
                }
            }
            else if (season == "Winter")
            {
                discount = 0.9;

                if (accommodType == "Hotel")
                {
                    totalPrice = daysCount * 40 * discount;
                }
                else if (accommodType == "Camping")
                {
                    totalPrice = daysCount * 10 * discount;
                }
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}