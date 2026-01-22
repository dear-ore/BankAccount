namespace BankAccounts
{
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public decimal TotalLimit { get; set; }


        public CurrentAccount(string name, string accNumber, decimal initialBal, decimal overdraftBal = 5000m) : base(name, accNumber, initialBal)
        {
            OverdraftLimit = overdraftBal;
        }

        public override void Withdraw(decimal amount)
        {
            TotalLimit = Balance + OverdraftLimit;
         
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero");
            }
            if (amount > TotalLimit)
            {
                throw new InvalidOperationException($"Insufficient funds. Balance: {TotalLimit:C}, Withdrawal: {amount:C}");
            }

            if (amount >= Balance)
            {
                Balance -= amount;
            }

            TotalLimit -= amount;
        }

        public decimal CheckOverdraftLimit()
        {
            return -OverdraftLimit;
        }
    }
}
// Should inherit from BankAccount - done
// Add an OverdraftLimit property (e.g., 5000m) -done
// Override the Withdraw method to allow going negative up to the overdraft limit
// Example: Balance is ₦2,000, OverdraftLimit is ₦5,000
// Should be able to withdraw up to ₦7,000 total