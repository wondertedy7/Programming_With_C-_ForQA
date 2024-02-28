namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double area = 0;
            double sideA = 0;
            double sideB = 0;

            //if (figureType != "square" && figureType != "rectangle" && figureType != "circle")
            //{
            //    Console.WriteLine("Invalid figure.");
            //}
            //else if (figureType == "square" || figureType == "circle" || figureType == "rectangle")
            //{
            //    switch (figureType)
            //    {
            //        case "square":
            //            sideA = double.Parse(Console.ReadLine());
            //            area = sideA * sideA;
            //            break;
            //        case "rectangle":
            //            sideA = double.Parse(Console.ReadLine());
            //            sideB = double.Parse(Console.ReadLine());
            //            area = sideA * sideB;
            //            break;
            //        case "circle":
            //            sideA = double.Parse(Console.ReadLine());
            //            area = (sideA * sideA) * Math.PI;
            //            break;
            //    }
            //    Console.WriteLine($"{area:f2}");
            //}

            while (true)
            {
                if (figureType != "square" && figureType != "rectangle" && figureType != "circle")
                {
                    Console.WriteLine("Invalid figure.");
                    break;
                }

                if (figureType == "square" || figureType == "rectangle" || figureType == "circle")
                {
                    switch (figureType)
                    {
                        case "square":
                            sideA = double.Parse(Console.ReadLine());
                            area = sideA * sideA;
                            break;
                        case "rectangle":
                            sideA = double.Parse(Console.ReadLine());
                            sideB = double.Parse(Console.ReadLine());
                            area = sideA * sideB;
                            break;
                        case "circle":
                            sideA = double.Parse(Console.ReadLine());
                            area = (sideA * sideA) * Math.PI;
                            break;
                    }
                }
                Console.WriteLine($"{area:f2}");
                break;
            }
        }
    }
}