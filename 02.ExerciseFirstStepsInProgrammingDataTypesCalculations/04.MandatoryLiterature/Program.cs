namespace _04.MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            int bookPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysToFinish = int.Parse(Console.ReadLine());

            int hoursForReading = 0;

            //logic

            int totalReadingTime = bookPages / pagesPerHour;
            hoursForReading = totalReadingTime / daysToFinish;

            //output

            Console.WriteLine(hoursForReading);




        }
    }
}