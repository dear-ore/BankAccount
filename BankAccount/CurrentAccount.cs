namespace BankAccounts
{
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; private set; }

        //public decimal TotalLimit { get; private set; }

        public CurrentAccount(string name, string accNumber, decimal initialBal, decimal overdraftBal = 5000m) : base(name, accNumber, initialBal)
        {
            OverdraftLimit = overdraftBal;
        }

        public override void Withdraw(decimal amount)
        {
            decimal totalLimit = Balance + OverdraftLimit;
         
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero");
            }

            if (amount > totalLimit)
            {
                throw new InvalidOperationException($"Insufficient funds. Balance: {totalLimit:C}, Withdrawal: {amount:C}");
            }

            if (amount >= Balance)
            {
                decimal remainder = amount - Balance;
                OverdraftLimit -= remainder;
                Balance = 0;
            }

            if (amount < Balance)
            {
                Balance -= amount;
            }
        }

        public decimal CheckOverdraftLimit()
        {
            return -OverdraftLimit;
        }
    }
}
// Should inherit from BankAccount - done
// Add an OverdraftLimit property (e.g., 5000m) -done
// Override the Withdraw method to allow going negative up to the overdraft limit - done
// Example: Balance is ₦2,000, OverdraftLimit is ₦5,000
// Should be able to withdraw up to ₦7,000 total