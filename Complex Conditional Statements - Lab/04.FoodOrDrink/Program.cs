namespace _04.FoodOrDrink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            string productType = "";

            if (product == "curry" || product == "noodles" || product == "sushi" || product == "spaghetti" || product == "bread")
            {
                productType = "food";
            }
            else if (product == "tea" || product == "water" || product == "coffee" 
                || product == "juice")
            {
                productType = "drink";
            }
            else
            {
                productType = "unknown";
            }
            Console.WriteLine(productType); 
        }
    }
}