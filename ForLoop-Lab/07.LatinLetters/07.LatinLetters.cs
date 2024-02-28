namespace _07.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());

            for (char i = letter1; i <= letter2; i++)
            {
                Console.Write($"{i} ");
            }

            // ***** for with while
            
            //while (letter1 <= letter2)
            //{
            //    Console.Write(letter1);
            //    letter1++;
            //}
        }
    }
}