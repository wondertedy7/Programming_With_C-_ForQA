namespace _07.SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNum = int.Parse(Console.ReadLine());

            int num = 0;
            double previousNum = 0;

            while (num != stopNum)
            {
                previousNum = num;

                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(previousNum *= 1.2);
        }
    }
}