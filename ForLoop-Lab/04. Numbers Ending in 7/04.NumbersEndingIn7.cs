namespace _04._Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());



            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 10 == 7)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // *********

            for (int i = 7; i <= n; i += 10)
            {
                Console.WriteLine(i);
            }

            // *********

            //for (int i = 7; i <= n; i++)
            //{
            //    string numAsString = i.ToString();
            //    char lastDigit = numAsString[numAsString.Length - 1];

            //    if (lastDigit == '7')
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // ***** for with while

            //int num = 7;

            //while (num <= n)
            //{
            //    Console.WriteLine(num);
            //    num += 10;
            //}

        }
    }
}