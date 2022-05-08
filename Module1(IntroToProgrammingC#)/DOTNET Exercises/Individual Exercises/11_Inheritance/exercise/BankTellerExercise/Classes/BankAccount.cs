namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        //Constructors
        public BankAccount (string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
        }
        public BankAccount (string accountHolderName, string accountNumber, decimal balance)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        //Properties
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; } 

        //Methods
        public decimal Deposit(decimal amountToDeposit)
        {
            return Balance += amountToDeposit;
        }
        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            return Balance -= amountToWithdraw;
        }
    }
}
