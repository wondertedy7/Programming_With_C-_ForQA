namespace _08.SortedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            string order = "";

            if (num1 < num2 && num2 < num3)
            {
                order = "Ascending";
            }
            else if (num1 > num2 && num2 > num3)
            {
                order = "Descending";
            }
            else
            {
                order = "Not sorted";
            }
            Console.WriteLine(order);
        }
    }
}