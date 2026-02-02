using BankAccounts;

Console.WriteLine("=======Testing Bank Account Search=============");

BankAccount regularCustomer = new BankAccount("Tina Turner", "1234567890", 3000m);
BankAccount savingsCustomer1 = new SavingsAccount("Wale Turner", "1234567891", 5000m);
BankAccount currentCustomer2 = new CurrentAccount("Tina Turner", "1234567892", 2000m);
BankAccount regularCustomer3 = new BankAccount("Wale Turner", "1234567893", 7000m);
BankAccount savingsCustomer4 = new SavingsAccount("Tina Turner", "1234567894", 20000m);
BankAccount currentCustomer5 = new CurrentAccount("Wale Turner", "1234567895", 15000m);

Bank myBank = new Bank();
myBank.AddAccount(regularCustomer);
myBank.AddAccount(savingsCustomer1);
myBank.AddAccount(currentCustomer2);
myBank.AddAccount(regularCustomer3);
myBank.AddAccount(savingsCustomer4);
myBank.AddAccount(currentCustomer5);

//myBank.FindAccount("1234567890");
//myBank.FindAccount("1234567891");

//Console.WriteLine($"Total Balance is {myBank.GetTotalDeposits()}");
var savingAccountCount = myBank.GetAccountByTypes<SavingsAccount>();

Console.WriteLine($"Present Savings Account: {savingAccountCount.Count()}");

//Console.WriteLine("=================TESTING BANK ACCOUNT METHODS===================");
//newCustomer.Deposit(20000m);
//Console.WriteLine($"New balance after 20,000 deposit {newCustomer.Balance}"); //should be 50,000

//newCustomer.Withdraw(10000m);
//Console.WriteLine($"New balance after 10,000 withdrawal {newCustomer.Balance}"); //should be 40,000

////test CheckBalance method

//Console.WriteLine($"Latest balance is {newCustomer.CheckBalance()}");

//Console.WriteLine("==================Testing Savings Account Methods================");
//SavingsAccount newCustomer = new SavingsAccount("Tina Turner", "1234567890", 0, 0.05m);
//Console.WriteLine($"Account Holder - {newCustomer.AccountHolder}");
//Console.WriteLine($"Account Number - {newCustomer.AccountNumber}");
//Console.WriteLine($"Account Balance - {newCustomer.Balance}");


//Console.WriteLine("=================TESTING BANK ACCOUNT METHODS===================");
//newCustomer.Deposit(40000m);
//Console.WriteLine($"New balance after 20,000 deposit {newCustomer.Balance}"); 

//newCustomer.Withdraw(50000m);
//Console.WriteLine($"New balance after 10,000 withdrawal {newCustomer.Balance}"); 


//Console.WriteLine($"Latest balance is {newCustomer.CheckBalance()}");

//Console.WriteLine($"Interest on latest balance is {newCustomer.CalculateInterest()}");

//newCustomer.ApplyInterest();

//Console.WriteLine($"Balance after applying interest is {newCustomer.CheckBalance()}");

//Console.WriteLine("=====================TESTING EXCEPTION HANDLING============================================");

//Console.WriteLine("=================TESTING CURRENT ACCOUNT==================");

//CurrentAccount currentCustomer = new CurrentAccount("Tope Yepa", "1234567890", 2000);
//Console.WriteLine($"Account Holder - {currentCustomer.AccountHolder}");
//Console.WriteLine($"Account Number - {currentCustomer.AccountNumber}");
//Console.WriteLine($"Account Balance - {currentCustomer.Balance}");
//Console.WriteLine($"Overdraft Limit - {currentCustomer.OverdraftLimit}");

//currentCustomer.Withdraw(2000);

//Console.WriteLine($"Account Balance after withdrawal - {currentCustomer.Balance}");
////Console.WriteLine($"Total Limit after withdrawal - {currentCustomer.TotalLimit}");
//Console.WriteLine($"Overdraft Limit after withdrawal - {currentCustomer.OverdraftLimit}");




