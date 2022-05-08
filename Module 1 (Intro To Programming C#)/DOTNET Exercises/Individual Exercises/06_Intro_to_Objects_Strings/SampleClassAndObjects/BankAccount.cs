using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClassAndObjects
{
    class BankAccount
    {
        public decimal balance = 0.0M;

        public decimal Deposit (decimal amount)
        {
            balance += amount;
            return balance;
        }

        public decimal Withdrawal(decimal amount)
        {
            balance -= amount;
            return balance;
        }
    }
}
