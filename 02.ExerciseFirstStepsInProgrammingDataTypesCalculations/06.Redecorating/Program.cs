namespace _06.Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Protective nylon -1.50 BGN per square meter
            //•	Paint - 14.50 BGN per liter
            //•	Paint thinner -5.00 BGN per liter

            //input

            int nylonAmout = int.Parse(Console.ReadLine());
            int paintAmount = int.Parse(Console.ReadLine());
            int thinnerQuantity = int.Parse(Console.ReadLine());
            int hoursForWork = int.Parse(Console.ReadLine());

            double bags = 0.40;
            int totalNylon = nylonAmout + 2;
            double totalPaint = paintAmount + paintAmount * 0.1;

            //logic

            double totalMaterialsPrice = totalNylon * 1.50 + totalPaint * 14.50 + thinnerQuantity
                * 5.00 + bags;
            double oneHourPayment = totalMaterialsPrice * 0.3;
            double totalCosts = totalMaterialsPrice + oneHourPayment * hoursForWork;

            //output

            Console.WriteLine(totalCosts);

        }
    }
}