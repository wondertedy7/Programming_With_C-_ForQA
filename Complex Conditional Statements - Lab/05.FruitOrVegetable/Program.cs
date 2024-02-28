namespace _05.FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            string productType = "";

            if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon")
            {
                productType = "fruit";
            }
            else if (product == "cucumber" || product == "pepper" || product == "carrot")
            {
                productType = "vegetable";
            }
            else
            {
                productType = "unknown";
            }
            Console.WriteLine(productType);
        }
    }
}