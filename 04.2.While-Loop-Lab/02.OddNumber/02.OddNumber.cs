namespace _02.OddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int odd = 0;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 != 0)
                {
                    odd = num;
                    break;
                }
            }
            Console.WriteLine(odd);
        }
    }
}