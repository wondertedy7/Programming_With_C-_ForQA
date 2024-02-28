namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            
            double deposit = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double totalAmount = 0;
            double totalInterestRate = 0;
            double monthlyInterestRate = 0;

            //logic


            totalInterestRate = deposit * annualInterestRate / 100;
            monthlyInterestRate = totalInterestRate / 12;
            totalAmount = deposit + termOfDeposit * monthlyInterestRate;

            //output

            Console.WriteLine(totalAmount);


        }
    }
}