namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input            

            string type = Console.ReadLine();
            int rowsNum = int.Parse(Console.ReadLine());
            int columnsNum = int.Parse(Console.ReadLine());

            double income = 0;

            //logic

            if (type == "Premiere")
            {
                income = rowsNum * columnsNum * 12;
            }
            else if (type == "Normal")
            {
                income = rowsNum * columnsNum * 7.50;
            }
            else if (type == "Discount")
            {
                income = rowsNum * columnsNum * 5;
            }

            //output

            Console.WriteLine($"{income:f2} leva");



            // other solution

            //string type = Console.ReadLine();
            //int rowsNum = int.Parse(Console.ReadLine());
            //int columnsNum = int.Parse(Console.ReadLine());

            //double income = rowsNum * columnsNum;

            //if (type == "Premiere")
            //{
            //    income *= 12;
            //}
            //else if (type == "Normal")
            //{
            //    income *= 7.5;
            //}
            //else if (type == "Discount")
            //{
            //    income *= 5;
            //}

            //Console.WriteLine($"{income:f2} leva");
        }
    }
}