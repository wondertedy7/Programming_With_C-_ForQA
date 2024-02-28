namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string numSpecial;
            int singleDigit;

            for (int i = 1111; i <= 9999; i++)
            {
                string specialNum = i.ToString();
                int counter = 0;

                for (int j = 0; j < specialNum.Length; j++)
                {
                    singleDigit = int.Parse(specialNum[j].ToString());

                    if (singleDigit == 0)
                    {
                        break;
                    }
                    if (num % singleDigit == 0)
                    {
                        counter++;
                    }

                }
                if (counter == 4)
                {
                    Console.Write($"{specialNum} ");
                }
            }        
        }
    }
}