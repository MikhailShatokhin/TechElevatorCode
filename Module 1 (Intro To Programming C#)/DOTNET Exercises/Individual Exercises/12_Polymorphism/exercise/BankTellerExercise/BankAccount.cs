﻿namespace BankTellerExercise
{
    public class BankAccount : IAccountable
    {
        //Properties
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Balance { get; private set; }

        //Constructors
        public BankAccount(string accountHolder, string accountNumber)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public BankAccount(string accountHolder, string accountNumber, decimal balance)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        //Methods
        public decimal Deposit(decimal amountToDeposit)
        {
            Balance += amountToDeposit;
            return Balance;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance -= amountToWithdraw;
            return Balance;
        }

        public decimal TransferTo(BankAccount destinationAccount, decimal transferAmount)
        {
            Withdraw(transferAmount);
            destinationAccount.Deposit(transferAmount);
            return Balance;
        }
    }
}