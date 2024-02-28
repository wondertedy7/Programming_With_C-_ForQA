namespace _06.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());

            //int digit;
            //int digitCounter = 0;
            //int counter = 0;
            //int num1 = num;

            //while (num1 > 0)
            //{
            //    digit = num1 % 10;
            //    digitCounter++;
            //    if (num % digit == 0)
            //    {
            //        counter++;
            //    }
            //    num1 /= 10;
            //}
            //if (digitCounter == counter)
            //{
            //    Console.WriteLine($"{num} is special");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is not special");
            //}

            // *****

            int num = int.Parse(Console.ReadLine());

            bool isSpecial = true;
            int startNum = num;

            while (num > 0)
            {
                int lastDigit = num % 10;
                if (startNum % lastDigit != 0)
                {
                    isSpecial = false;
                    break;
                }
                num /= 10;
            }
            if (isSpecial)
            {
                Console.WriteLine($"{startNum} is special");
            }
            else
            {
                Console.WriteLine($"{startNum} is not special");
            }

        }
    }
}