namespace _04.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());

            //int sumDigits = 0;
            //int singleDigit;

            //string digits = num.ToString();
            //int numLength = digits.Length;

            //for (int i = 0; i < digits.Length; i++)
            //{
            //    singleDigit = int.Parse(digits[i].ToString());

            //    sumDigits += singleDigit;
            //}
            //Console.WriteLine(sumDigits);

            // *********

            int num = int.Parse(Console.ReadLine());

            int sumdigits = 0;

            while (num > 0)
            {
                int singledigit = num % 10; // get the last digit
                sumdigits += singledigit;
                num /= 10; // remove the last digit
            }

            Console.WriteLine(sumdigits);
        }
    }
}