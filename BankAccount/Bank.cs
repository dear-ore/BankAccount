using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Bank
    {
    }
}

// Manages multiple accounts
// List<BankAccount> Accounts property
// Methods:
//   - AddAccount(BankAccount account)
//   - FindAccount(string accountNumber) - use LINQ
//   - GetTotalDeposits() - sum all balances using LINQ
//   - GetAccountsByType<T>() where T : BankAccount - use LINQ with OfType<T>()