namespace BankAccounts
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public string AccountHolder { get; }
        public decimal Balance { get; protected set; }

        //Other implementations
        //require account number length = 10;
        public BankAccount(string name, string accNumber, decimal initialBal)
        {
            if (initialBal < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative");
            }
            AccountHolder = name;
            AccountNumber = accNumber;
            Balance = initialBal;
            //Bank.AddAccount();
        }

        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException($"The amount you want to deposit must be greater than zero!");
            }
            Balance += amount;
            //return Balance;
        }

        public virtual void Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero");
            }
            if(amount > Balance)
            {
                throw new InvalidOperationException ($"Insufficient funds. Balance: {Balance:C}, Withdrawal: {amount:C}");
            }

            Balance -= amount;
            //return Balance;
        }

        public decimal CheckBalance()
        {
            return Balance;
        }
    }
}
