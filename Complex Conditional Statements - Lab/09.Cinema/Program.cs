namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int seatsPerRowCount = int.Parse(Console.ReadLine());
            int rowsCount = int.Parse(Console.ReadLine());

            int totalSeats = rowsCount * seatsPerRowCount;
            double totalPrice = 0;

            if (typeOfMovie == "Premiere")
            {
                totalPrice = totalSeats * 12.00;
            }
            else if (typeOfMovie == "Normal")
            {
                totalPrice = totalSeats * 7.50;
            }
            else if (typeOfMovie == "Discount")
            {
                totalPrice = totalSeats * 5.00;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}