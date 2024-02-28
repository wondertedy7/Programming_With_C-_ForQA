namespace _09.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int totalTimeMinutes = time1 + time2 + time3;

            int minutes = totalTimeMinutes / 60;
            int seconds = totalTimeMinutes % 60;

            Console.WriteLine($"{minutes}:{seconds:d2}");

        }
    }
}