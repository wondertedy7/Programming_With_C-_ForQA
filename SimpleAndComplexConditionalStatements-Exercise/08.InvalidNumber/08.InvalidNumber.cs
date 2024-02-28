namespace _08.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num != 0 && num < 100 || num > 200)
            {
                Console.WriteLine("invalid");
            }

            // *******
            //if (num == 0 || num >= 100 && num <= 200)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}

            // ********

            //bool isValid = (num >= 100 && num <= 200) || num == 0;

            //if (!isValid)
            //{
            //    Console.WriteLine("invalid");
            //}

        }
    }
}