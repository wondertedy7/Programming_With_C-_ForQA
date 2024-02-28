namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В това демо показваме работа с char и int и взаимодействието между тях");

            char test = 'A'; // or 'a', or '%', or 'z' ... etc.
            int testASCIINumber = (int)test; // converts the char into number
            Console.WriteLine(test);
            Console.WriteLine("converts the char into number");
            Console.WriteLine(testASCIINumber);

            Console.WriteLine();

            Console.WriteLine("* * * * * * * *");

            //*****
            Console.WriteLine("convert the int - 75 into char:");
            int testNumber = 75;
            Console.WriteLine((char)testNumber); // converts the integer into char
            Console.WriteLine("* * * * * * * *");

            // *****
            char theSymbolA = 'A';
            Console.WriteLine("We take a symbol like 'A' and increment it with ++A and we have the next letter in the alphabet ");

            Console.WriteLine($"принтира буквата {theSymbolA}");
            Console.WriteLine($"принтира следващата буква от азбуката - {++theSymbolA}"); // prints the next letter
            Console.WriteLine($"и следващата - {++theSymbolA}... и т.н.");
            Console.WriteLine("* * * * * * * *");

            // *****

            Console.WriteLine("С този for цикъл принтираме малките букви от английската азбука:");
            Console.WriteLine();
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}