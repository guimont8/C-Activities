using ExercicioError;
using System.Globalization;

try
{
    Console.WriteLine("Enter account data: ");
    Console.Write("Number: ");
    int numberAcc = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string nameAcc = Console.ReadLine();
    Console.Write("Initial Balance: ");
    double balanceAcc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw Limit: ");
    double withdrawAcc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account account = new(numberAcc, nameAcc, balanceAcc, withdrawAcc);
    Console.WriteLine("-----------------------------------------------------");
    Console.Write("\nEnter the amount for withdraw: ");
    double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account.Withdraw(withdrawAmount);
    Console.WriteLine(account);
}
catch(ApplicationException e) 
{
    Console.WriteLine(e.Message);
}
