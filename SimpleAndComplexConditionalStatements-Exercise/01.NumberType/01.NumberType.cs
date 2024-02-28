namespace _01.NumberType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string numType = "";

            switch (num)
            {
                case (< 0):
                    numType = "negative";
                    break;
                case (> 0):
                    numType = "positive";
                    break;
                default:
                    numType = "zero";
                    break;
            }
            Console.WriteLine(numType);
        }
    }
}