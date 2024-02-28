namespace _06.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string day = "";

            if (num == 1)
            {
                day = "Monday";
            }
            else if (num == 2)
            {
                day = "Tuesday";
            }
            else if (num == 3)
            {
                day = "Wednesday";
            }            
            else if (num == 4)
            {
                day = "Thursday";
            }
            else if (num == 5)
            {
                day = "Friday";
            }
            else if (num == 6)
            {
                day = "Saturday";
            }
            else if (num == 7)
            {
                day = "Sunday";
            }
            else
            {
                day = "Error";
            }
            Console.WriteLine(day);
        }
    }
}