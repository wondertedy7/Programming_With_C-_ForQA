namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double num;
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                num = double.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);

            // ***** for loop with while 

            //int i = 1;

            //while (i <= n)
            //{
            //    num = double.Parse(Console.ReadLine());
            //    sum += num;
            //    i++;
            //}
            //Console.WriteLine(sum);
        }
    }
}