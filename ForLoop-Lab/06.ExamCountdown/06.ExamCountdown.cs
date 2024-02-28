namespace _06.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            for (int i = days; i >= 1; i--)
            {
                Console.WriteLine($"{i} days before the exam");
            }
            Console.WriteLine("The exam has come");

            // ***** for with while

            //while (days > 0)
            //{
            //    Console.WriteLine($"{days} days before the exam");
            //    days--;
            //}
            //Console.WriteLine("The exam has come");

        }
    }
}