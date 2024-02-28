
List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command;

while ((command = Console.ReadLine()) != "end")
{
    //string[] commandParts = command.Split(" ");
    //string commandName = commandParts[0];
    //int element = int.Parse(commandParts[1]);

    //if (commandName == "Add")
    //{
    //    numbers.Add(element);
    //}
    //else if (commandName == "Remove")
    //{
    //    numbers.Remove(element);
    //}
    //else if (commandName == "RemoveAt")
    //{
    //    numbers.RemoveAt(element);
    //}
    //else if (commandName == "Insert")
    //{
    //    int position = int.Parse(commandParts[2]);
    //    numbers.Insert(position, element);
    //}

    // *************

    if (command.StartsWith("Add"))
    {
        int numberToAdd = int.Parse(command.Split(" ")[1]);
        //сплитваме command по интервал -> получаваме масив от текстовете "Add" и "3"
        //-> ["Add", "3"]
        //след което взимаме елемента за добавяне (в случая той е на позиция [1])
        numbers.Add(numberToAdd);
    }
    else if (command.StartsWith("RemoveAt"))
    {
        int indexToRemove = int.Parse(command.Split(" ")[1]);
        numbers.RemoveAt(indexToRemove);
    }
    else if (command.StartsWith("Remove"))
    {
        int numToRemove = int.Parse(command.Split(" ")[1]);
        numbers.Remove(numToRemove);
    }
    else if (command.StartsWith("Insert"))
    {
        int numToInsert = int.Parse(command.Split(" ")[1]);
        int indexToInsert = int.Parse(command.Split(" ")[2]);
    }

}
Console.WriteLine(string.Join(" ", numbers));

