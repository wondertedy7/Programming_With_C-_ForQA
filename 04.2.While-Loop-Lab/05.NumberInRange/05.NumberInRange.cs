namespace _05.NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());

            //bool inRange = num >= 1 && num <= 100;

            //while (!inRange)
            //{
            //    num = int.Parse(Console.ReadLine());
            //    inRange = num >= 1 && num <= 100;
            //}
            //Console.WriteLine(num);

            // *****


            //int num = 0;

            //while (true)
            //{
            //    num = int.Parse(Console.ReadLine());

            //    if (num >= 1 && num <= 100)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(num);

            // *****

            int num = 0;

            while (num < 1 || num > 100)
            {
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
        }
    }
}