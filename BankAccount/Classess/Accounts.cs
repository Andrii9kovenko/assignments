using System;

namespace BankAccount.Classess;

public class Accounts
{
    private string accountName;
    private double accountBalance;

    public Accounts(string name, double startingAmount)
    {
        accountName = name;

        if (startingAmount >= 0)
        {
            accountBalance = startingAmount;
        }
        else
        {
            accountBalance = 0;
        }
    }

    public void Top_up(double amount)
    {
        if (amount > 0)
        {
            accountBalance = accountBalance + amount;
        }
    }

    public void Withdrawal(double amount)
    {
        if (amount > 0 && amount <= accountBalance)
        {
            accountBalance = accountBalance - amount;
        }
    }

    public double Balance
    {
        get { return accountBalance; }
    }

    public string Name
    {
        get { return accountName; }
    }
}
