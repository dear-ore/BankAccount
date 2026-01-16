using BankAccounts;

BankAccount customer1 = new BankAccount("Tayo Fedeco", "123567890", 20000);

Console.WriteLine(customer1.AccountHolder);
Console.WriteLine(customer1.Balance);
Console.WriteLine(customer1.AccountNumber);

Console.WriteLine(customer1.Deposit(10000));
Console.WriteLine(customer1.Withdraw(30000));
