namespace BankAccounts
{
    public class Bank
    {
        private List<BankAccount> Accounts {get; set;}
        public Bank()
        {
            Accounts = new List<BankAccount>();
        }

        public void AddAccount(BankAccount account)
        {
            Accounts.Add(account);
            Console.WriteLine($"Account {account.AccountNumber} was added successfully!");
        }

        public BankAccount? FindAccount(string accountNumber)
        {
            return Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
        }

        public decimal GetTotalDeposits()
        {
            return Accounts.Sum(a => a.Balance);
        }

        public List<T> GetAccountByTypes<T>() where T : BankAccount
        {
            return Accounts.OfType<T>().ToList();
        }
        
    }
}

