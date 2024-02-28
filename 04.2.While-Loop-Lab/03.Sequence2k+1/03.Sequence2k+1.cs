namespace _03.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());
            int num = 1;
            //Console.WriteLine(num);

            //while (true)
            //{
            //    num = num * 2 + 1;

            //    if (num > maxNum)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(num);
            //}

            // *****

            while (num <= maxNum)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }

            // *****

            //for (int i = 1; i <= maxNum; i = i * 2 + 1)
            //{
            //    Console.WriteLine(i);
            //}

        }
    }
}