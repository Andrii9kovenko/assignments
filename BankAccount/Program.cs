using BankAccount.Classess;

Console.Clear();
Console.WriteLine($"The balance on the my accounts: ");

Account MySalaryAccount = new Account("Salary account", 1000.00);
Account MyDepositAccount = new Account("Deposit account", 100000.00);

MySalaryAccount.Withdrawal(250);
Console.WriteLine( "\n Salary account: " + MySalaryAccount.Balance);

MyDepositAccount.TopUp(230);
Console.WriteLine($"\n Deposit account: " + MyDepositAccount.Balance);