namespace _03.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favorite = Console.ReadLine();

            int counter = 0;
            bool bookIsFound = false;

            string nextBook;

            while ((nextBook = Console.ReadLine()) != "No More Books")
            {
                if (nextBook == favorite)
                {
                    bookIsFound = true;
                    break;
                }
                counter++;
            }

            if (bookIsFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }

            // other solution

            //while ((nextBook = Console.ReadLine()) != "No More Books" && nextBook != favorite)
            //{
            //    counter ++;
            //}
            //if (nextBook == favorite)
            //{
            //    Console.WriteLine($"You checked {counter} books and found it.");
            //}
            //else
            //{
            //    Console.WriteLine("The book you search is not here!");
            //    Console.WriteLine($"You checked {counter} books.");
            //}
        }
    }
}