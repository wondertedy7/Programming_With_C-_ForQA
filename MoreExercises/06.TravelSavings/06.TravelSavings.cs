
string destination = "";

while ((destination = Console.ReadLine()) != "End")
{
    double budget = double.Parse(Console.ReadLine());
    double sum = 0;

    string command = "";

    while ((command = Console.ReadLine()) != "enough" )
    {
        double money = double.Parse(command);
        sum += money;

        Console.WriteLine($"Collected: {sum:f2}");
        if (sum >= budget)
        {
            Console.WriteLine($"Going to {destination}!");
            break;
        }
    }
}