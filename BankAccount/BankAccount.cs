namespace BankAccounts
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public string AccountHolder { get; }
        public decimal Balance { get; private set; }

        //Other implementations
        //require account number length = 10;
        public BankAccount(string name, string accNumber, decimal initialBal)
        {
            AccountHolder = name;
            AccountNumber = accNumber;
            Balance = initialBal;
        }

        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException($"The amount you want to deposit should be greater than zero!");
            }
            Balance += amount;
            //return Balance;
        }

        public void Withdraw(decimal amount)
        {
            if(amount > Balance)
            {
                throw new ArgumentOutOfRangeException($"The amount - ({amount}) you're trying to withdraw is larger than your current balance({Balance}). Try again with a smaller amount!");
            }

            Balance -= amount;
            //return Balance;
        }
    }
}
