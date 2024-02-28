namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //input

            int annualTrainingFee = int.Parse(Console.ReadLine());

            //logic

            double sneakersPrice = annualTrainingFee - annualTrainingFee * 0.4;
            double teamPrice = sneakersPrice - sneakersPrice * 0.2;
            double basketballPrice = teamPrice / 4;
            double accessoriesPrice = basketballPrice / 5;

            double totalCosts = annualTrainingFee + sneakersPrice + teamPrice 
                + basketballPrice + accessoriesPrice;

            //output

            Console.WriteLine(totalCosts);
        }
    }
}