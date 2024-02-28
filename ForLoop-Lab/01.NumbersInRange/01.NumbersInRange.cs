namespace _01.NumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }

            // ***** for loop with while loop

            //int num = num1;

            //while (num <= num2)
            //{
            //    Console.WriteLine(num);
            //    num++;
            //}
        }
    }
}