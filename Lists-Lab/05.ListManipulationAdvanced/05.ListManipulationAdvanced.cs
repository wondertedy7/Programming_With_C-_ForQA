
List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command;

while ((command = Console.ReadLine()) != "end")
{
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];
    

    if (commandName == "Contains")
    {
        int element = int.Parse(commandParts[1]);        

        if (numbers.Contains(element))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (commandName == "PrintEven")
    {
        for (int index = 0; index < numbers.Count - 1; index++)
        {
            int currentNum = numbers[index];
            if (currentNum % 2 == 0)
            {
                Console.Write(currentNum + " ");
            }
        }
        Console.WriteLine();
    }
    else if (commandName == "PrintOdd")
    {
        for (int index = 0; index < numbers.Count - 1; index++)
        {
            int currentNum = numbers[index];
            if (currentNum % 2 != 0)
            {
                Console.Write(currentNum + " ");
            }
        }
        Console.WriteLine();
    }
    else if (commandName == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (commandName == "Filter")
    {
        List<int> filteredNum = new List<int>();
        for (int index = 0; index <= numbers.Count - 1; index++)
        {
            if (commandParts[1] == ">")
            {
                if (numbers[index] > int.Parse(commandParts[2]))
                {
                    filteredNum.Add(numbers[index]);
                }
            }
            else if (commandParts[1] == "<")
            {
                if (numbers[index] < int.Parse(commandParts[2]))
                {
                    filteredNum.Add(numbers[index]);
                }
            }
            if (commandParts[1] == ">=")
            {
                if (numbers[index] >= int.Parse(commandParts[2]))
                {
                    filteredNum.Add(numbers[index]);
                }
            }
            if (commandParts[1] == "<=")
            {
                if (numbers[index] <= int.Parse(commandParts[2]))
                {
                    filteredNum.Add(numbers[index]);
                }
            }
        }
        Console.WriteLine(string.Join(" ", filteredNum));
    }  

}
Console.WriteLine(string.Join(" ", numbers));


