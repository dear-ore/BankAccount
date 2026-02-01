namespace BankAccounts
{
    public class Bank
    {
        public List<BankAccount> Accounts {get; set;}
        public Bank()
        {
            Accounts = new List<BankAccount>();
        }

        public void AddAccount(BankAccount account)
        {
            Accounts.Add(account);
            Console.WriteLine($"Account {account.AccountNumber} was added successfully!");
        }

        public BankAccount FindAccount(string accountNumber)
        {
            BankAccount foundAccount = Accounts
                .FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (foundAccount != null)
            {
                Console.WriteLine($"{foundAccount.AccountHolder}, {foundAccount.AccountNumber}b");
                return foundAccount;
            }
            else
            {
                return default;
            }
        }

        //public BankAccount FindAccount(string accountNumber)
        //{
        //    IEnumerable<BankAccount> accountQuery =
        //        from account in Accounts
        //        where account.AccountNumber == accountNumber
        //        select account;

        //    foreach (BankAccount account in accountQuery)
        //    {
        //        return account;
        //    }


        //}
    }
}

// Manages multiple accounts
// List<BankAccount> Accounts property
// Methods:
//   - AddAccount(BankAccount account) - 
//   - FindAccount(string accountNumber) - use LINQ
//   - GetTotalDeposits() - sum all balances using LINQ
//   - GetAccountsByType<T>() where T : BankAccount - use LINQ with OfType<T>()

//Store all accounts - Keep a list of all customer accounts (savings, current, regular)
//Add new accounts - When a new customer opens an account, add it to the bank
//Find specific accounts - When a customer comes in with their account number, find their account
//Generate reports - Like "what's the total money in our bank?" or "how many savings accounts do we have?"