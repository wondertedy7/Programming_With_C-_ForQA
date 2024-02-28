namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string message = "";


            if (n % 2 == 0)
            {
                message = "The number is divisible by 2";
            }
            if (n % 3 == 0)
            {
                message = "The number is divisible by 3";
            }
            if (n % 6 == 0)
            {
                message = "The number is divisible by 6";
            }
            if (n % 7 == 0)
            {
                message = "The number is divisible by 7";
            }
            if (n % 2 == 0 && n % 3 == 0 && n % 6 == 0)
            {
                message = "The number is divisible by 6";
            }
            if (n % 2 == 0 && n % 10 == 0)
            {
                message = "The number is divisible by 10";
            }
            if (n % 2 != 0 && n % 3 != 0 && n % 6 != 0 && n % 10 != 0)
            {
                message = "Not divisible";
            }
            Console.WriteLine(message);

        }
    }
}