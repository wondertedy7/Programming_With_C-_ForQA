namespace _02.LargestNumberOutOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int largestNum = 0;

            if (num1 > num2 && num1 > num3)
            {
                largestNum = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                largestNum = num2;
            }
            else
            {
                largestNum = num3;
            }
            Console.WriteLine(largestNum);
        }
    }
}