namespace _05.TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            int packOfPens = int.Parse(Console.ReadLine());
            int packOfMarkers = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            //•	Package of pens - 5.80 lv. 
            //•	Package of markers - 7.20 lv.
            //•	Board cleaner -1.20 BGN(per liter)

            //logic

            double totalPrice = (packOfPens * 5.80) + (packOfMarkers * 7.20) + (boardCleaner * 1.20);
            double discountedPrice = totalPrice - totalPrice * discountPercent / 100;

            //output

            Console.WriteLine(discountedPrice);
        }
    }
}