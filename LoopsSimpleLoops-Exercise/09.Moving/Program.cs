using System;

namespace _09.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = width * length * height;

            string command;

            while ((command = Console.ReadLine()) != "Done" && freeSpace > 0)
            {
                int boxesMoved = int.Parse(command);
                freeSpace -= boxesMoved;
            }
            if (freeSpace < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }


            // other solution

            //while (freeSpace >= 0)
            //{
            //    command = Console.ReadLine();
            //    if (command == "Done")
            //    {
            //        break;
            //    }
            //    int boxesMoved = int.Parse(command);
            //    freeSpace -= boxesMoved;
            //}
            //if (freeSpace >= 0)
            //{
            //    Console.WriteLine($"{freeSpace} Cubic meters left.");
            //}
            //else
            //{
            //    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            //}
        }
    }
}