namespace _05.DivisionTo2_3And4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;

            for (int i = 1; i <= N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    counter2++;
                }
                if (num % 3 == 0)
                {
                    counter3++;
                }
                if (num % 4 == 0)
                {
                    counter4++;
                }
            }
            Console.WriteLine($"{counter2 / N * 100:f2}%");
            Console.WriteLine($"{counter3 / N * 100:f2}%");
            Console.WriteLine($"{counter4 / N * 100:f2}%");
        }
    }
}