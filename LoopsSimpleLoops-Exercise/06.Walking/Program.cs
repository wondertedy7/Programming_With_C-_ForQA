namespace _06.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //logic

            string command;
            double goal = 10000;
            double difference = 0;
            double stepsReached = 0;

            while ((command = Console.ReadLine()) != "Going home")
            {
                double steps = double.Parse(command);
                stepsReached += steps;

                if (stepsReached >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsReached - goal} steps over the goal!");
                    break;
                }
            }
            if (command == "Going home")
            {
                double steps = double.Parse(Console.ReadLine());
                stepsReached += steps;
                if (stepsReached > goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsReached - goal} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{goal - stepsReached} more steps to reach goal.");
                }
            }
        }
    }
}