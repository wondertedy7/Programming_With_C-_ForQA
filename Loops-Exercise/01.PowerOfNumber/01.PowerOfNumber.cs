namespace _01.PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            // *****
            // Console.WriteLine(Math.Pow(n, p));

            int result = 1;

            for (int i = 1; i <= p; i++)
            {
                result *= n;
            }
            Console.WriteLine(result);
        }
    }
}