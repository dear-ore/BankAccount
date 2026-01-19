
namespace BankAccounts
{
    public class SavingsAccount : BankAccount
    {
       // public decimal SavingsBalance { get; set; }
        public decimal InterestRate { get; set;  }  //percent
        public SavingsAccount(string name, string accNumber, decimal initialBal, decimal interestRate = 0.10m) : base(name, accNumber, initialBal)
        {
            InterestRate = interestRate;
        }

        public decimal CalculateInterest()
        {
            return InterestRate * Balance;
        }

        //public int GetSavingsAndInterest()
        //{
        //    int interest = CalculateInterest();
        //    return interest + SavingsBalance;
        //}

        public void ApplyInterest()
        {
            decimal interest = CalculateInterest();
            Deposit(interest);
        }
    }
}
