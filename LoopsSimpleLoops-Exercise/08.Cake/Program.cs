namespace _08.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int piecesOfCake = width * height;
            string input;

            while ((input = Console.ReadLine()) != "STOP")
            {
                int piecesTaken = int.Parse(input);

                piecesOfCake -= piecesTaken;

                if (piecesOfCake < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(piecesOfCake)} pieces more.");
                    break;
                }
            }
            if (piecesOfCake >= 0)
            {
                Console.WriteLine($"{piecesOfCake} pieces are left.");
            }
            //else
            //{
            //    Console.WriteLine($"No more cake left! You need {Math.Abs(piecesOfCake)} pieces more.");
            //}
        }
    }
}