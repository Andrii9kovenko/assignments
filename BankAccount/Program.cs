using BankAccount.Classess;

Console.Clear();
Console.WriteLine($"The balance on the my accounts: ");

Accounts MySalaryAccount = new Accounts("Salary account", 1000.00);
Accounts MyDepositAccount = new Accounts("Deposit account", 1000000.00);

MySalaryAccount.Withdrawal(300);
Console.WriteLine( "\n Salary account: " + MySalaryAccount.Balance);

MyDepositAccount.Top_up(200);
Console.WriteLine($"\n Deposit account: " + MyDepositAccount.Balance);