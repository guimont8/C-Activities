using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace ExercicioError;

internal class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }

    public Account() { }

    public Account(int number, string holder, double balance, double withdrawLimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawLimit;
    }
    public void Deposit(double amount)
    {
        Balance += amount;
    }
    public void Withdraw(double amount)
    {
        if (amount > Balance || amount > WithdrawLimit)
        {
            throw new ApplicationException("Error ! You don't have limit or amount for this withdraw");
        }
        else
        {
            Balance -= amount;
        }
   
    }
    public override string ToString() 
    {
        return "The new balance is " + Balance;
    }

}
