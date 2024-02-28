namespace _09.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentOccupied = double.Parse(Console.ReadLine());

            //logic

            double volume = length * width * height;
            double volumeL = volume / 1000;

            double totalLiters = volumeL - volumeL * percentOccupied / 100;
            //output

            Console.WriteLine($"{totalLiters:f2}");
        }
    }
}