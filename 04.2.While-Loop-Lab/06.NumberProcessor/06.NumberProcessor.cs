namespace _06.NumberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Inc")
                {
                    num += 1;
                }
                else if (command == "Dec")
                {
                    num -= 1;
                }
            }
            Console.WriteLine(num);
        }
    }
}