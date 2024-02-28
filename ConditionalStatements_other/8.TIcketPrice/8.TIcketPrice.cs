namespace _8.TIcketPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();

            double studentPrice = 1.00;
            double regularPrice = 1.60;

            if (ticketType == "student")
            {
                Console.WriteLine($"${studentPrice:f2}");
            }
            else if (ticketType == "regular")
            {
                Console.WriteLine($"${regularPrice:f2}");
            }
            else
            {
                Console.WriteLine("Invalid ticket type!");
            }
        }
    }
}