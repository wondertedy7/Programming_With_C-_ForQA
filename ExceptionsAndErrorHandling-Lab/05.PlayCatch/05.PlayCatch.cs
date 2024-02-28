
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

string command = Console.ReadLine();

int exceptionsCount = 0;

while (exceptionsCount < 3)
{
    string[] commandParameters = command.Split();

    try
    {
        string manipulateCommand = commandParameters[0];

        if (manipulateCommand == "Replace")
        {
            int index = int.Parse(commandParameters[1]);
            int element = int.Parse(commandParameters[2]);

            numbers[index] = element;
        }
        else if (manipulateCommand == "Print")
        {
            int startIndex = int.Parse(commandParameters[1]);
            int endIndex = int.Parse(commandParameters[2]);

            int[] toPrint = new int[endIndex - startIndex + 1];
            int counter = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                toPrint[counter] = numbers[i];
                counter++;
            }
            Console.WriteLine(string.Join(", ", toPrint));
        }
        else if (manipulateCommand == "Show")
        {
            int index = int.Parse(commandParameters[1]);
            Console.WriteLine(numbers[index]);
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("The variable is not in the correct format!");
        exceptionsCount++;
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("The index does not exist!");
        exceptionsCount++;
    }
    finally
    {
        if (exceptionsCount < 3)
        {
            command = Console.ReadLine();
        }
    }
}
Console.WriteLine(string.Join(", ", numbers));
