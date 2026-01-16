namespace BankAccounts
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public string AccountHolder { get; }
        public int Balance { get; set; }

        //Other implementations
        //require account number length = 10;
        public BankAccount(string name, string accNumber, int initialBal)
        {
            AccountHolder = name;
            AccountNumber = accNumber;
            Balance = initialBal;
        }

        public int  Deposit(int amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException($"The amount you want to deposit should be greater than zero!");
            }
            Balance += amount;
            return Balance;
        }

        public int Withdraw(int amount)
        {
            if(amount > Balance)
            {
                throw new ArgumentOutOfRangeException($"The amount - ({amount}) you're trying to withdraw is larger than your current balance({Balance}). Try again with a smaller amount!");
            }

            Balance -= amount;
            return Balance;
        }
    }
}
