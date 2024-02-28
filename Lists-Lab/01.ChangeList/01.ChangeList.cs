
List<int> numbers = Console.ReadLine() // "1 2 3 4 5 5 5 6"- текста, който се въвежда от конзолата
                    .Split(" ")        // ["1", "2", "3", "4", "5", "5", "5", "6"]-масив от текстовете, които сме сплитнали по интервал 
                    .Select(int.Parse) // {1. 2, 3, 4, 5, 5, 5, 6]- получаваме масив от цели числа
                    .ToList();          // преобразуваме масива в лист от цели числа.

string command;

while ((command = Console.ReadLine()) != "end")
{
    //валидна команда
    //1. command = "Delete 5".Split(" ") -> ["Delete", "5"] - масив от разделените текстове
    //2. command = Insert 10 1".Split(" ") -> ["Insert", "5", "0"] - масив от разделените текстове 
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];// имe на команда: "Delete" или "Insert"
    int element = int.Parse(commandParts[1]);

    if (commandName == "Delete")
    {
        numbers.RemoveAll(number => number == element);
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(commandParts[2]);

        numbers.Insert(position, element);
    }
}
Console.WriteLine(string.Join(" ", numbers));