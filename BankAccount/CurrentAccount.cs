namespace BankAccounts
{
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; }

        //public decimal TotalLimit { get; private set; }

        public CurrentAccount(string name, string accNumber, decimal initialBal, decimal overdraftBal = 5000m) : base(name, accNumber, initialBal)
        {
            OverdraftLimit = overdraftBal;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero");
            }

            decimal totalLimit = Balance + OverdraftLimit;

            if (amount > totalLimit)
            {
                throw new InvalidOperationException($"Insufficient funds. Balance: {totalLimit:C}, Withdrawal: {amount:C}");
            }

            Balance -= amount;
        }

        public decimal GetUsedOverdraft()
        {
            return Balance < 0 ? Math.Abs(Balance) : 0;
        }

        public decimal GetAvailableOverdraft()
        {
            return Balance < 0 ? OverdraftLimit - Math.Abs(Balance) : OverdraftLimit;
        }
    }
}
