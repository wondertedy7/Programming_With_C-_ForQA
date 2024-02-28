namespace _03.SumOfPrimeAndNon_PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            int sumOfPrime = 0;
            int sumOfNonPrime = 0;
            bool isNegative = false;

            while ((command = Console.ReadLine()) != "stop")
            {
                //int num = int.Parse(command);
                int num = Convert.ToInt32(command);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                int divisors = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        divisors++;
                    }
                }
                if (divisors == 2)
                {
                    sumOfPrime += num;
                }
                else
                {
                    sumOfNonPrime += num;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrime}");
        }
    }
}