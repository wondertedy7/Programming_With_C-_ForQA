﻿namespace _1.FreezingWeather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp = double.Parse(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Freezing weather!");
            }
        }
    }
}