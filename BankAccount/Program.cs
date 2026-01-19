using BankAccounts;

Console.WriteLine("=======Testing Bank Account OOP=============");

BankAccount newCustomer = new BankAccount("Tina Turner", "1234567890", 30000m);
Console.WriteLine($"Account Holder - {newCustomer.AccountHolder}");
Console.WriteLine($"Account Number - {newCustomer.AccountNumber}");
Console.WriteLine($"Account Balance - {newCustomer.Balance}");


Console.WriteLine("=================TESTING BANK ACCOUNT METHODS===================");
newCustomer.Deposit(20000m);
Console.WriteLine($"New balance after 20,000 deposit {newCustomer.Balance}"); //should be 50,000

newCustomer.Withdraw(10000m);
Console.WriteLine($"New balance after 10,000 withdrawal {newCustomer.Balance}"); //should be 40,000

//test CheckBalance method

Console.WriteLine($"Latest balance is {newCustomer.CheckBalance()}");

