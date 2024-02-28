namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Chicken menu – 10.35 lv.
            //•	Menu with fish – 12.40 lv.
            //•	Vegetarian menu – 8.15 lv.
            // delivery - 2.50 lv.

            //input

            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegMenus = int.Parse(Console.ReadLine());

            //logic

            double allMenusCost = chickenMenus * 10.35 + fishMenus * 12.40
                + vegMenus * 8.15;
            double desertPrice = allMenusCost * 0.2;

            double totalCost = allMenusCost + desertPrice + 2.50;

            //output

            Console.WriteLine(totalCost);
        }
    }
}