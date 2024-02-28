namespace _03.BiggestOfFiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            int greatestNum = 0;

            if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            {
                greatestNum = num1;
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
            {
                greatestNum = num2;
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
            {
                greatestNum = num3;
            }
            else if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
            {
                greatestNum = num4;
            }
            else if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
            {
                greatestNum = num5;
            }
            Console.WriteLine(greatestNum);
        }
    }
}