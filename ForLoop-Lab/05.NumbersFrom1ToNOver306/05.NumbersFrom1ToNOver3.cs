﻿namespace _05.NumbersFrom1ToNOver306
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }

            // ***** for with while

            //int num = 1;

            //while (num <= n)
            //{
            //    Console.WriteLine(num);
            //    num += 3;
            //}
        }
    }
}