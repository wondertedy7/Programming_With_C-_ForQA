namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName;
            int availableSeats;
            int student = 0;
            int standart = 0;
            int kid = 0;
            int totalTickets = 0;
            int allTickets = 0;

            while ((movieName = Console.ReadLine ()) != "Finish")
            {
                availableSeats = int.Parse(Console.ReadLine());

                for (int i = 1; i <= availableSeats; i++)
                {
                    string typeOfTicket = Console.ReadLine();
                    int tickets = 0;

                    if (typeOfTicket == "student")
                    {
                        student++;
                        tickets ++;
                    }
                    else if (typeOfTicket == "standard")
                    {
                        standart++;
                        tickets ++;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        kid++;
                        tickets ++;
                    }
                    else if (typeOfTicket == "End")
                    {
                        break;
                    }
                    totalTickets += tickets;
                    allTickets += tickets;
                }
                Console.WriteLine($"{movieName} - {(double)allTickets / availableSeats * 100:f2}% full.");
                allTickets = 0;
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)student / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standart / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kid / totalTickets * 100:f2}% kids tickets.");





        }
    }
}