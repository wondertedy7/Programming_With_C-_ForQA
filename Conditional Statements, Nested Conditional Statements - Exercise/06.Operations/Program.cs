namespace _06.Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());

            double result = 0;

            //logic

            if (oper == '+')
            {
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - odd");
                }
            }
            else if (oper == '-')
            {
                result = N1 - N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - odd");
                }
            }
            else if (oper == '*')
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - odd");
                }
            }
            else if (oper == '/')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} / {N2} = {(double)N1 / N2:f2}");
                }
            }
            else if (oper == '%')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} % {N2} = {N1 % N2}");
                }
            }
            // SECOND SOLUTION

            //// user input

            //double n1 = double.parse(console.readline());
            //double n2 = double.parse(console.readline());
            //string oper = console.readline();

            //// logic

            //double result = 0;

            //switch (oper)
            //{
            //    case "+":
            //        result = N1 + N2;

            //        if (result % 2 == 0)
            //        {
            //            Console.WriteLine($"{N1} + {N2} = {result} - even");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{N1} + {N2} = {result} - odd");
            //        }
            //        break;
            //    case "-":
            //        result = N1 - N2;
            //        if (result % 2 == 0)
            //        {
            //            Console.WriteLine($"{N1} - {N2} = {result} - even");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{N1} - {N2} = {result} - odd");
            //        }
            //        break;
            //    case "*":
            //        result = N1 * N2;
            //        if (result % 2 == 0)
            //        {
            //            Console.WriteLine($"{N1} * {N2} = {result} - even");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{N1} * {N2} = {result} - odd");
            //        }
            //        break;
            //}

            //// output

            //if (N2 == 0)
            //{
            //    Console.WriteLine($"Cannot divide {N1} by zero");
            //}
            //else if (oper == "/")
            //{
            //    result = N1 / N2;
            //    Console.WriteLine($"{N1} / {N2} = {result:f2}");
            //}
            //else if (oper == "%")
            //{
            //    result = N1 % N2;
            //    Console.WriteLine($"{N1} % {N2} = {result}");
            //}
        }
    }
}