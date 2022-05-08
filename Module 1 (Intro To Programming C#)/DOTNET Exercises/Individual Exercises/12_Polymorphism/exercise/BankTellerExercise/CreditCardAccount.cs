using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CreditCardAccount : IAccountable
    {
        //Constructors
        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
        }

        //Properties
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Debt { get; private set; } = 0.00M;
        public decimal Balance { get; private set; }

        //Methods
        public decimal Pay(decimal amountToPay)
        {
            Debt -= amountToPay;
            return Balance = Debt*-1;
        }
        public decimal Charge(decimal amountToCharge)
        {
            Debt += amountToCharge;
            return Balance = Debt*-1;
        }
    }
}
