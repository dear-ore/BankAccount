namespace BankAccount
{ 
    public class BankAccount
    {
        public string AccountNumber { get; }
        public string AccountHolder { get; set; }
        public int Balance { get; }
        public BankAccount(string name, string accnumber, int initialBal)
        {
            AccountHolder = name;
            AccountNumber = accnumber;
            Balance = initialBal;
        }

        public int Deposit(int amount)
        {
            int newBalance = Balance + amount;
            return newBalance;
        }

        public int Withdraw(int amount)
        {
            if(amount > Balance)
            {
                throw new ArgumentOutOfRangeException($"The amount ({amount}) you're trying to withdraw is larger than your current balance. Try again with a smaller amount");
            }

            return Balance - amount;
        }
    }
}
