namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string currentNum = num.ToString();
            //int length = currentNum.Length;
            int sum = 0;
            for (int i = 0; i < currentNum.Length; i++)
            {
                char digit = currentNum[i];
                int intValue = int.Parse(digit.ToString());

                int factorial = 1;

                for (int j = 1; j <= intValue; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}