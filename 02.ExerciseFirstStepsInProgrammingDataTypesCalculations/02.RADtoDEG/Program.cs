namespace _02.RADtoDEG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angleRad = double.Parse(Console.ReadLine());

            double angleDeg = angleRad * 180 / Math.PI;

            Console.WriteLine(angleDeg);
        }
    }
}