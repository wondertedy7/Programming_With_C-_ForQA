namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double LightsabersCount = Math.Ceiling(studentsCount * 1.10);
            double beltCount = studentsCount;
            int freeBelts = studentsCount / 6;

            if (freeBelts >= 1)
            {
                beltCount = studentsCount - freeBelts;
            }

            double totalPrice = LightsabersCount * lightsaberPrice +
                 studentsCount * robePrice + beltCount * beltPrice;

            if (moneyAmount >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - moneyAmount:f2}lv more.");
            }
        }
    }
}