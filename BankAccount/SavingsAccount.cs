
namespace BankAccounts
{
    public class SavingsAccount : BankAccount
    {
        public int SavingsBalance { get; set; }
        public int InterestRate { get; } = 10; //percent
        public SavingsAccount(string name, string accNumber, int initialBal) : base(name, accNumber, initialBal)
        {
            
        }

        public int CalculateInterest()
        {
            return (InterestRate / 100) * SavingsBalance;
        }

        public int GetSavingsAndInterest()
        {
            int interest = CalculateInterest();
            return interest + SavingsBalance;
        }
    }
}
