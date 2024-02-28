namespace _03.NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            //logic

            switch (flowerType)
            {
                //case "Roses":
                //    if (flowerCount > 80)
                //    {
                //        price = flowerCount * 5 * 0.9;
                //    }
                //    else
                //    {
                //        price = flowerCount * 5;
                //    }
                //    break;

                // за да се съкрати кода, може да се напише по следния начин:

                case "Roses":

                    price = flowerCount * 5;

                    if (flowerCount > 80)
                    {
                        price *= 0.9;
                    }
                    break;
                // същото важи и за другите кейсове!

                case "Dahlias":
                    if (flowerCount > 90)
                    {
                        price = flowerCount * 3.80 * 0.85;
                    }
                    else
                    {
                        price = flowerCount * 3.80;
                    }
                    break;
                case "Tulips":
                    if (flowerCount > 80)
                    {
                        price = flowerCount * 2.80 * 0.85;
                    }
                    else
                    {
                        price = flowerCount * 2.80;
                    }
                    break;
                case "Narcissus":
                    if (flowerCount < 120)
                    {
                        price = flowerCount * 3 * 1.15; 
                    }
                    else
                    {
                        price = flowerCount * 3;
                    }
                    break;
                case "Gladiolus":
                    if (flowerCount < 80)
                    {
                        price = flowerCount * 2.50 * 1.20;
                    }
                    else
                    {
                        price = flowerCount * 2.50;
                    }
                    break;
            }

            //output

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }

        }
    }
}