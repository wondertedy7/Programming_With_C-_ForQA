namespace _02.FirstNNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    sum += i;
            //    if (i == n)
            //    {
            //        Console.Write(i);
            //    }
            //    else
            //    {
            //        Console.Write($"{i}+");
            //    }
            //}
            //Console.WriteLine($"={sum}");


            // за да избегнем проблема със знака "+", 
            //който се появява при последното печатане
            // пишем кода по следния начин:

            int sum = 1; // пишем още в началото сумата да е 1

            Console.Write(sum); // и я отпечатваме на конзолата

            for (int i = 2; i <= n; i++) // започваме цикъла от 2
            {
                Console.Write($"+{i}");
                sum += i;
            }
            Console.Write($"={sum}");

            // ***** for loop with while loop

            //int iterator = 1;
            //int sum = 1;
            //Console.Write(iterator);

            //while (iterator < n)
            //{
            //    iterator++;
            //    sum += iterator;
            //    Console.Write($"+{iterator}");
            //}
            //Console.WriteLine($"={sum}");
        }
    }
}