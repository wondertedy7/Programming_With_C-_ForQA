
using System.Security.Principal;

string[] inputAccounts = Console.ReadLine().Split(",");

Dictionary<int, double> accounts = new Dictionary<int, double>();
int accountNumber = 0;
double accountBallance = 0;

foreach (string item in inputAccounts)
{
    string[] accountParts = item.Split("-");
    accountNumber = int.Parse(accountParts[0]);
    accountBallance = double.Parse(accountParts[1]);

    accounts[accountNumber] = accountBallance;
}
string command = "";

while ((command = Console.ReadLine()) != "End")
{
    string[] actions = command.Split();

    string action = actions[0];
    accountNumber = int.Parse(actions[1]);
    double sum = double.Parse(actions[2]);


    if (action == "Deposit")
    {
        accounts[accountNumber] += sum;
        Console.WriteLine($"Account {accountNumber} has new balance: {accountBallance}");
    }
    else if (action == "Withdraw")
    {
        accounts[accountNumber] -= sum;
        Console.WriteLine($"Account {accountNumber} has new balance: {accountBallance}");
    }
    Console.WriteLine("Enter another command");
}