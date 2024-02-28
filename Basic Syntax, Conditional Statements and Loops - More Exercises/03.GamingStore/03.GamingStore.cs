
using System.Reflection;

double balance = double.Parse(Console.ReadLine());

double finalBalance = balance;
string command = "";
double moneySpent = 0;

// OutFall 4 - $39.99
// CS: OG - $15.99
// Zplinter Zell - $19.99
// Honored 2 - $59.99
// RoverWatch - $29.99
// RoverWatch Origins Edition - $39.99

while ((command = Console.ReadLine()) != "Game Time")
{
    if (finalBalance <= 0)
    {
        Console.WriteLine("Out of money!");
        break;
    }

	if (command == "OutFall 4")
	{
        if (finalBalance < 39.99)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }
		finalBalance -= 39.99;
        moneySpent += 39.99;
		Console.WriteLine($"Bought {command}");
	}
	else if (command == "CS: OG")
    {
        if (finalBalance < 15.99)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }
        finalBalance -= 15.99;
        moneySpent += 15.99;
        Console.WriteLine($"Bought {command}");
    }
    else if (command == "Zplinter Zell")
    {
        if (finalBalance < 19.99)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }
        finalBalance -= 15.99;
        moneySpent += 15.99;
        Console.WriteLine($"Bought {command}");
    }
    else if (command == "Honored 2")
    {
        if (finalBalance < 59.99)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }
        finalBalance -= 59.99;
        moneySpent += 59.99;
        Console.WriteLine($"Bought {command}");
    }
    else if (command == "RoverWatch")
    {
        if (finalBalance < 29.99)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }
        finalBalance -= 29.99;
        moneySpent+= 29.99;
        Console.WriteLine($"Bought {command}");
    }
    else if (command == "RoverWatch Origins Edition")
    {
        if (finalBalance < 39.99)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }
        finalBalance -= 39.99;
        moneySpent += 39.99;
        Console.WriteLine($"Bought {command}");
    }
    else
    {
        Console.WriteLine("Not Found");
        continue;
    }
}

Console.WriteLine($"Total spent: ${moneySpent:f2}. Remaining: ${balance - moneySpent:f2}");