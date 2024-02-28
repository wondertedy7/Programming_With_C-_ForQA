
string command = "";

while ((command = Console.ReadLine()) != "End")
{
    int number = int.Parse(command);
    int sumOfDigits = 0;

    //***** with for loop -->

    //for (int i = number; i > 0; i /= 10)
    //{
    //    int digit = i % 10;
    //    sumOfDigits += digit;
    //}

    while (number > 0)
    {
        int digit = number % 10;
        sumOfDigits += digit;
        number /= 10;
    }
    Console.WriteLine($"Sum of digits = {sumOfDigits}");
}
Console.WriteLine("Goodbye");
