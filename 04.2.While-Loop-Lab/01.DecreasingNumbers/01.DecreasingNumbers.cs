namespace _01.DecreasingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());

            while (numN >= 1)
            {
                Console.WriteLine(numN);
                numN--;
            }
        }
    }
}