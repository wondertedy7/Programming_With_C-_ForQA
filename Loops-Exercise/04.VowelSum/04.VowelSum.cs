using System.Linq.Expressions;

namespace _04.VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int vowelSum = 0;

            for (int i = 1; i <= N; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                switch (letter)
                {
                    case 'a':
                        vowelSum += 1;
                        break;
                    case 'e':
                        vowelSum += 2;
                        break;
                    case 'i':
                        vowelSum += 3;
                        break;
                    case 'o':
                        vowelSum += 4;
                        break;
                    case 'u':
                        vowelSum += 5;
                        break;
                }

            }
            Console.WriteLine(vowelSum);
        }
    }
}