using System;

namespace SampleClassAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BankAccount checkingAccount = new BankAccount();
            BankAccount savingsAccount = new BankAccount();
            checkingAccount.balance = 3.00M;

            checkingAccount.Deposit(100.00M);
            checkingAccount.Withdrawal(50.00M);

            savingsAccount.Deposit(1000.00M);

            Console.WriteLine(checkingAccount.balance);
            Console.WriteLine(savingsAccount.balance);
        }
    }
}
