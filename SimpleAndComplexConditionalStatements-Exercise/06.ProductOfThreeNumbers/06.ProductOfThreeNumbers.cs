namespace _06.ProductOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            string sign = "";
            int countNegative = 0;

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                sign = "zero";
            }
            //else if (num1 > 0 && num2 > 0 && num3 > 0)
            //{
            //    sign = "positive";
            //}
            //else if (num1 > 0 && num2 > 0 && num3 < 0)
            //{
            //    sign = "negative";
            //}
            //else if (num1 > 0 && num2 < 0 && num3 > 0)
            //{
            //    sign = "negative";
            //}
            //else if (num1 > 0 && num2 < 0 && num3 < 0)
            //{
            //    sign = "positive";
            //}
            //else if (num1 < 0 && num2 > 0 && num3 > 0)
            //{
            //    sign = "negative";
            //}
            //else if (num1 < 0 && num2 > 0 && num3 < 0)
            //{
            //    sign = "positive";
            //}
            //else if (num1 < 0 && num2 < 0 && num3 > 0)
            //{
            //    sign = "positive";
            //}
            //else if (num1 < 0 && num2 < 0 && num3 < 0)
            //{
            //    sign = "negative";
            //}

            else
            {
                if (num1 < 0)
                {
                    countNegative++;
                }
                if (num2 < 0)
                {
                    countNegative++;
                }
                if (num3 < 0)
                {
                    countNegative++;
                }

                if (countNegative == 0 || countNegative == 2)
                {
                    sign = "positive";
                }
                else
                {
                    sign = "negative";
                }
            }

            Console.WriteLine(sign);
        }
    }
}